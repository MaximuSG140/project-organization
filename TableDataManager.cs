using Microsoft.Extensions.Logging;

namespace ProjectOrganization
{
    internal class TableDataManager<TEntity> : ITableDataViewManager where TEntity : class, new()
    {
        private static Logger<TableDataManager<TEntity>> logger = new(LoggerFactory.Create(builder => { }));
        private DataGridView view = null!;
        private List<TEntity> tableData = null!;

        public void StartManaging(DataGridView gridView)
        {
            view = gridView;
            var properties = TableInfoParser<TEntity>.PropertiesTypes;
            foreach (var property in properties)
            {
                DataGridViewColumn propertyColumn = new();
                propertyColumn.Name = property.Key.ToSnakeCase();
                propertyColumn.CellTemplate = new DataGridViewTextBoxCell();
                propertyColumn.ValueType = property.Value;
                view.Columns.Add(propertyColumn);
            }
            FillTable();
            view.CellEndEdit += OnCellEdited;
        }

        private void FillTable()
        {
            tableData = new List<TEntity>();
            var connection = DatabaseConnectionFactory.Instance.DatabaseConnection;
            var table = connection.Get<TEntity>();
            foreach (var row in table.Rows)
            {
                tableData.Add(row);
                var index = view.Rows.Add();
                var gridRow = view.Rows[index];
                var values = TableInfoParser<TEntity>.GetPropertiesValues(row);
                foreach (var value in values)
                {
                    gridRow.Cells[value.Key.ToSnakeCase()].Value = value.Value;
                }
            }
        }

        private void OnCellEdited(object? sender, DataGridViewCellEventArgs e)
        {
            var table = DatabaseConnectionFactory.Instance.DatabaseConnection.Get<TEntity>();
            var modifiedRow = view.Rows[e.RowIndex];
            var modifiedCell = modifiedRow.Cells[e.ColumnIndex];
            var oldValue = tableData[e.RowIndex];
            TEntity copy = new();
            TableInfoParser<TEntity>.Assign(oldValue, copy);
            try
            {
                var update = table.Rows.Update(oldValue);
                TableInfoParser<TEntity>.SetProperty(oldValue, modifiedCell.OwningColumn.Name.ToCamelCase(), modifiedCell.Value);
                table.SaveChanges();
            }
            catch (Exception exception)
            {
                logger.LogCritical(exception.Message);
                MessageBox.Show("Error editing table", "Error", MessageBoxButtons.OK);
                var column = modifiedCell.OwningColumn;
                var property = TableInfoParser<TEntity>.GetPropertyByName(column.Name.ToCamelCase());
                modifiedCell.Value = property.GetValue(copy);
            }
        }

        public void StopManaging()
        {
            view.CellEndEdit -= OnCellEdited;
        }

        public void InsertRow(object data)
        {
            var table = DatabaseConnectionFactory.Instance.DatabaseConnection.Get<TEntity>();
            try
            {
                table.Rows.Add((TEntity)data);
                table.SaveChanges();
            }
            catch(Exception exception)
            {
                logger.LogCritical(exception.Message);
                MessageBox.Show("Error adding data to table", "Error", MessageBoxButtons.OK);
                return;
            }
            tableData.Add((TEntity)data);
            var index = view.Rows.Add();
            var gridRow = view.Rows[index];
            var values = TableInfoParser<TEntity>.GetPropertiesValues((TEntity)data);
            foreach (var value in values)
            {
                gridRow.Cells[value.Key.ToSnakeCase()].Value = value.Value;
            }
        }

        public void DeleteRow(int index)
        {
            var deletedRow = tableData[index];
            var table = DatabaseConnectionFactory.Instance.DatabaseConnection.Get<TEntity>();
            try
            {
                table.Rows.Remove(deletedRow);
                table.SaveChanges();
            }
            catch (Exception exception)
            {
                logger.LogCritical(exception.Message);
                MessageBox.Show("Error removing row", "Error", MessageBoxButtons.OK);
                return;
            }
            tableData.RemoveAt(index);
            view.Rows.RemoveAt(index);
        }
    }
}

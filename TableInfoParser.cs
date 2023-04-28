using System.Reflection;
using System.Runtime.CompilerServices;

namespace ProjectOrganization
{
    internal class TableInfoParser<TEntity> where TEntity : class
    {
        public static Dictionary<string, Type> PropertiesTypes
        {
            get
            {
                var entityType = typeof(TEntity);
                var properties = entityType.GetProperties();
                Dictionary<string, Type> result = new();
                foreach (var property in properties)
                {
                    var type = property.PropertyType;
                    result.Add(property.Name, type);
                }

                return result;
            }
        }

        public static Dictionary<string, object> GetPropertiesValues(TEntity entity)
        {
            var type = typeof(TEntity);
            var properties = type.GetProperties();
            return properties.ToDictionary(property => property.Name, property => property.GetValue(entity)!);
        }

        public static PropertyInfo[] Properties
        {
            get
            {
                var entityType = typeof(TEntity);
                return entityType.GetProperties();
            }
        }

        public static void Assign(TEntity source, TEntity destination)
        {
            foreach (var property in Properties)
            {
                var propertyValue = property.GetValue(source)!;
                property.SetValue(destination, propertyValue);
            }
        }

        public static PropertyInfo GetPropertyByName(string name)
        {
            var entityType = typeof(TEntity);
            return entityType.GetProperty(name)!;
        }

        public static void SetProperty(TEntity entity, string name, object value)
        {
            var property = GetPropertyByName(name);
            property.SetValue(entity, value);
        }
    }

    internal class TableDataManager<TEntity> : ITableDataViewManager where TEntity : class, new()
    {
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
            var connection = DatabaseConnectionFactory.GetInstance().GetDatabaseConnection();
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
            var table = DatabaseConnectionFactory.GetInstance().GetDatabaseConnection().Get<TEntity>();
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
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK);
                var column = modifiedCell.OwningColumn;
                var property = TableInfoParser<TEntity>.GetPropertyByName(column.Name.ToCamelCase());
                modifiedCell.Value = property.GetValue(copy);
            }
        }

        public void StopManaging()
        {
            view.CellEndEdit -= OnCellEdited;
        }
    }
}

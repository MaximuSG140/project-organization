namespace ProjectOrganization;

internal class ReferencedEntityViewManager
{
    private readonly DataGridView view;
    public ReferencedEntityViewManager(DataGridView view)
    {
        this.view = view;
    }

    public void DisplayProperties(object entity)
    {
        view.Columns.Clear();
        var type = entity.GetType();
        var properties = type.GetProperties();
        foreach ( var property in properties )
        {
            DataGridViewColumn column = new();
            column.Name = property.Name.ToSnakeCase();
            column.CellTemplate = new DataGridViewTextBoxCell();
            view.Columns.Add(column);
        }

        var index = view.Rows.Add();
        var row  = view.Rows[index];
        foreach (var property in properties)
        {
            row.Cells[property.Name.ToSnakeCase()].Value = property.GetValue(entity);
        }
    }

    public void ResetView()
    {
        view.Columns.Clear();
    }
}
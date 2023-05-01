namespace ProjectOrganization;

public class TableDataViewManagerFactory
{
    private readonly Dictionary<string, ITableDataViewManager> managers =
        TableViewForm.TableNames.ToDictionary(name => name, CreateTableViewManagerFromTableName);

    private static Type MapTableNameToType(string tableName)
    {
        return TableViewForm.EntityTypeByTableName[tableName]!;
    }

    private static ITableDataViewManager CreateTableViewManagerFromTableName(string tableName)
    {
        var entityType = MapTableNameToType(tableName);
        var viewManagerType = typeof(TableDataManager<>).MakeGenericType(entityType);
        return (ITableDataViewManager)Activator.CreateInstance(viewManagerType)!;
    }

    public ITableDataViewManager GetManagerForTable(string tableName)
    {
        return managers[tableName];
    }
}
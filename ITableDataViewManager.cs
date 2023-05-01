namespace ProjectOrganization;

public interface ITableDataViewManager
{
    void StartManaging(DataGridView gridView);
    void InsertRow(object data);
    void DeleteRow(int index);
    void StopManaging();
}
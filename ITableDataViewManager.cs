namespace ProjectOrganization;

public interface ITableDataViewManager
{
    void StartManaging(DataGridView gridView);
    void StopManaging();
}
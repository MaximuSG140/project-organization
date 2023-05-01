namespace ProjectOrganization;

internal interface PredefinedQuery
{
    string Description
    {
        get;
    }

    void ExecuteQuery(DataGridView outputView);
    void CancelExecution();
}

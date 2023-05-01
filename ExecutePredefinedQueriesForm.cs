namespace ProjectOrganization;

public partial class ExecutePredefinedQueriesForm : Form
{
    private static readonly Dictionary<int, PredefinedQuery> queries = new()
    {
        {1, new GenericPredefinedQuery(new GenericPredefinedQuery.Parameters()
            {
                Command = "select employee_data.name from employee_data, employee_department_link, department_data " +
                    "where employee_data.id = employee_department_link.employee_id and " +
                    "department_data.id = employee_department_link.department_id and " +
                    "department_data.name = @department_name;",
                QueryParameters = new string[]{ "@department_name" },
                Description = "Get data on the composition of the specified department."
            }) },
        {2, new GenericPredefinedQuery (new GenericPredefinedQuery.Parameters()
            {
                Command = "select employee_data.name from employee_data, department_data "  +
                "where employee_data.id = department_data.leader_id;",
                QueryParameters = Array.Empty<string>(),
                Description = "Get a list of department heads."
            }) },
        {3, new GenericPredefinedQuery(new GenericPredefinedQuery.Parameters()
            {
                Command = "select project_data.name from project_data " +
                "where project_data.begin <= @date_begin and project_data.end >= @date_end;",
                QueryParameters = new string[]{ "@date_begin", "@date_end" },
                Description = "Get a list of contracts or projects being executed " +
                "at the moment or during the specified time interval."
            }) },
        {4, new GenericPredefinedQuery(new GenericPredefinedQuery.Parameters()
            {
                Command = "select deal_data.id from deal_project_link, deal_data " +
                    "where deal_data.id = deal_project_link.deal_id and deal_project_link.project_id = @project_id;",
                QueryParameters = new string[] { "@project_id" },
                Description = "Get information about what projects are being carried out (were being carried out) " +
                "which contracts are supported by these projects."
            }) },
        {5, new GenericPredefinedQuery(new GenericPredefinedQuery.Parameters()
            {
                Command = "select coalesce(sum(project_data.cost), 0) from deal_data, deal_project_link, project_data " +
                "where deal_data.id = deal_project_link.deal_id and project_data.id = deal_project_link.project_id " +
                "and deal_data.begin >= @date_begin and deal_data.end <= @date_end;",
                QueryParameters = new string[] { "@date_begin", "@date_end" },
                Description = "Get data on the cost of completed contracts " +
                "during the specified time period."
            }) },
        {6, new GenericPredefinedQuery(new GenericPredefinedQuery.Parameters()
            {
                Command =
                "select equipment_data.name, project_data.name from equipment_data, project_data, equipment_project_link " +
                "where equipment_data.id = equipment_project_link.equipment_id " +
                "and project_data.id = equipment_project_link.project_id " +
                "and project_data.begin <= @date and project_data.end >= @date;",
                QueryParameters = new string[] { "@date" },
                Description = "Get data on the distribution of equipment at the moment or on some specified date."
            }) },
        {7, new GenericPredefinedQuery(new GenericPredefinedQuery.Parameters()
            {
                Command = "select equipment_data.id from equipment_data, equipment_project_link, project_data " +
                "where equipment_data.id = equipment_project_link.equipment_id and " +
                "project_data.id = equipment_project_link.project_id and project_data.name = @project_name;",
                QueryParameters = new string[] { "@project_name" },
                Description = "Get information about the use of equipment by the specified projects."
            }) },
        {8, new GenericPredefinedQuery (new GenericPredefinedQuery.Parameters()
            {
                Command = "select project_data.name from project_data, employee_project_link, employee_data " +
                "where project_data.id = employee_project_link.project_id and " +
                "employee_data.id = employee_project_link.employee_id " +
                "and employee_data.name = @employee_name and project_data.begin >= @begin_date and " +
                "project_data.end <= @end_date;",
                QueryParameters = new string[] { "@employee_name", "@begin_date", "@end_date" },
                Description = "Get information about the participation of the specified employee " +
                "in projects for a certain period of time."
            }) },
        {9, new GenericPredefinedQuery(new GenericPredefinedQuery.Parameters()
            {
                Command = "select suborganization_data.name as subirgsnization_name, project_data.name as project_name, " +
                "suborganization_project_link.price " +
                "from suborganization_data, project_data, suborganization_project_link " +
                "where suborganization_data.id = suborganization_project_link.suborganization_id " +
                "and project_data.id = suborganization_project_link.project_id;",
                QueryParameters = Array.Empty<string>(),
                Description = "Get the list and cost of work performed by subcontractors."
            })},
        {10, new GenericPredefinedQuery(new GenericPredefinedQuery.Parameters()
            {
                Command = "select count(*) from employee_data, employee_project_link, project_data " +
                "where employee_data.id = employee_project_link.employee_id and " +
                "project_data.id = employee_project_link.project_id " +
                "and project_data.name = @project_name group by employee_data.title_id;",
                QueryParameters = new string[] { "@project_name" },
                Description = "Get data on the number and composition of employees in " +
                "general participating in the specified project."
            }) },
        {11, new GenericPredefinedQuery(new GenericPredefinedQuery.Parameters()
            {
                Command =
                "select equipment_data.name, sum(project_data.cost) " +
                "from project_data, equipment_project_link, equipment_data " +
                "where project_data.id = equipment_project_link.project_id " +
                "and equipment_data.id = equipment_project_link.equipment_id group by equipment_data.id;",
                QueryParameters = Array.Empty<string>(),
                Description = "Get data on the efficiency of equipment use (the volume of design " +
                "work performed using this or that equipment)."
            }) },
        {12, new GenericPredefinedQuery(new GenericPredefinedQuery.Parameters ()
            {
                Command = "select deal_data.id, sum(project_data.cost) / datediff(deal_data.end, deal_data.end) " +
                "from project_data, deal_project_link, deal_data " +
                "where project_data.id = deal_project_link.project_id and deal_data.id = deal_project_link.deal_id " +
                "group by deal_data.id;",
                QueryParameters = Array.Empty<string>(),
                Description = "Get information about the effectiveness of contracts (the cost of contracts " +
                "correlated with the time spent)."
            }) },
        {13, new GenericPredefinedQuery(new GenericPredefinedQuery.Parameters()
            {
                Command =
                "select employee_data.name from employee_data, employee_project_link, project_data, title_data " +
                "where employee_data.id = employee_project_link.employee_id and " +
                "project_data.id = employee_project_link.project_id and employee_data.title_id = title_data.id and " +
                "project_data.begin >= @begin_date and project_data.end <= @end_date and title_data.name = @title_name;",
                QueryParameters = new string[] { "@begin_date", "@end_date", "@title_name" },
                Description = "Get data on the number of employees in general participating " +
                "in projects for a specified period of time."
            }) },
        {14, new GenericPredefinedQuery (new GenericPredefinedQuery.Parameters()
            {
                Command = "select project_data.id, project_data.cost/count(*) from project_data, employee_project_link " +
                "where project_data.id = employee_project_link.project_id group by project_data.id;",
                QueryParameters = Array.Empty<string>(),
                Description = "Get information about the effectiveness of projects " +
                "(taking into account the human resources involved)."
            }) }
    };

    private PredefinedQuery? currentQuery;

    public ExecutePredefinedQueriesForm()
    {
        InitializeComponent();
    }

    private void ExecutePredefinedQueriesForm_Load(object sender, EventArgs e)
    {
        queryNumberSelector.Items.Clear();
        foreach (var entry in queries)
        {
            queryNumberSelector.Items.Add(entry.Key);
        }
    }

    private void queryNumberSelector_SelectedIndexChanged(object sender, EventArgs e)
    {
        currentQuery?.CancelExecution();
        currentQuery = queries[int.Parse(queryNumberSelector.Text)];
        descriptionTextBox.Text = currentQuery.Description;
        dataGridView.Columns.Clear();
    }

    private void executeSelectedQueryButton_Click(object sender, EventArgs e)
    {
        currentQuery?.CancelExecution();
        currentQuery?.ExecuteQuery(dataGridView);
    }

    private void ExecutePredefinedQueriesForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        StartMenuForm.Instance.Show();
    }
}

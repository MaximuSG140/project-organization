using System.Diagnostics;

namespace ProjectOrganization
{
    public partial class TableViewForm : Form
    {
        public static readonly HashSet<string> TableNames = new()
        {
            "title_data", "employee_data", "project_data",
            "attribute_data", "deal_data", "suborganization_data", "customer_data", "department_data",
            "equipment_data", "deal_project_link", "employee_attribute_link", "employee_deal_link",
            "employee_department_link", "employee_project_link", "equipment_department_link",
            "equipment_project_link", "suborganization_project_link", "title_attribute_link"
        };

        private readonly TableDataViewManagerFactory factory = new();
        private ITableDataViewManager? viewManager;

        public TableViewForm()
        {
            InitializeComponent();
        }

        private void TableViewForm_Load(object sender, EventArgs e)
        {
            tableSelectorListBox.Items.Clear();
            foreach (var name in TableNames)
            {
                tableSelectorListBox.Items.Add(name);
            }
        }

        private void tableSelectorListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tableDataView.Columns.Clear();
            tableDataView.Rows.Clear();
            tableDataView.ClearSelection();
            viewManager?.StopManaging();
            viewManager = factory.GetManagerForTable(tableSelectorListBox.Text);
            viewManager.StartManaging(tableDataView);
        }

        private void TableViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = new StartMenuForm();
            mainMenu.Show();
        }
    }
}

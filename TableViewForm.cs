using System.Diagnostics;
using System.Reflection;

namespace ProjectOrganization;

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

    private static Type? GetTypeByName(string name)
    {
        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies().Reverse())
        {
            var tt = assembly.GetType("ProjectOrganization." + name);
            if (tt != null)
            {
                return tt;
            }
        }

        return null;
    }

    public static readonly Dictionary<string, Type> EntityTypeByTableName =
        TableNames.ToDictionary(table_name => table_name, table_name => GetTypeByName(table_name.ToCamelCase())!);

    private object? currentEntityForInsert;

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
        currentEntityForInsert = Activator.CreateInstance(EntityTypeByTableName[tableSelectorListBox.Text]);
        entityPropertiesRedactor.SelectedObject = currentEntityForInsert;
    }

    private void TableViewForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        StartMenuForm.Instance.Show();
    }

    private void addRecordButton_Click(object sender, EventArgs e)
    {
        if (currentEntityForInsert == null)
        {
            return;
        }
        viewManager?.InsertRow(currentEntityForInsert);
    }

    private void removeSelectedRowButton_Click(object sender, EventArgs e)
    {
        var selectedRows = tableDataView.SelectedRows;
        foreach (var row in selectedRows)
        {
            var index = ((DataGridViewRow)row).Index;
            viewManager?.DeleteRow((int)index);
        }
    }
}

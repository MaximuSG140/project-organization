using System.Net;

namespace ProjectOrganization;

public partial class StartMenuForm : Form
{
    public static StartMenuForm Instance
    {
        get; private set;
    } = new StartMenuForm();
    private StartMenuForm()
    {
        InitializeComponent();
    }

    private void editTablesButton_Click(object sender, EventArgs e)
    {
        try
        {
            DatabaseConnectionFactory.Instance.CreateDatabaseConnection(
                new IPAddress(new byte[4] { 127, 0, 0, 1 }), 3306, usernameTextBox.Text, passwordTextBox.Text);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            return;
        }

        var tableViewer = new TableViewForm();
        tableViewer.Show();
        Hide();
    }

    private void StartMenuForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        Application.Exit();
    }

    private void executeQueriesButton_Click(object sender, EventArgs e)
    {
        try
        {
            DatabaseConnectionFactory.Instance.CreateDatabaseConnection(
                new IPAddress(new byte[4] { 127, 0, 0, 1 }), 3306, usernameTextBox.Text, passwordTextBox.Text);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            return;
        }

        ExecutePredefinedQueriesForm executePredefinedQueriesForm = new();
        executePredefinedQueriesForm.Show();
        Hide();
    }
}
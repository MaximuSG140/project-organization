using System.Net;

namespace ProjectOrganization
{
    public partial class StartMenuForm : Form
    {
        public StartMenuForm()
        {
            InitializeComponent();
        }

        private void StartMenuForm_Load(object sender, EventArgs e)
        {
        }

        private void editTablesButton_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnectionFactory.GetInstance().CreateDatabaseConnection(
                    new IPAddress(new byte[4] {127, 0, 0, 1}), 3306, usernameTextBox.Text, passwordTextBox.Text);
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
    }
}
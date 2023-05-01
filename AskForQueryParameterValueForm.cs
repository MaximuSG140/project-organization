namespace ProjectOrganization;

public partial class AskForQueryParameterValueForm : Form
{
    private string? committedValue;
    private Action<string?> callback;

    public AskForQueryParameterValueForm(string parameter, Action<string?> callback)
    {
        InitializeComponent();
        this.callback = callback;
        parameterNameLabel.Text = parameter;
    }

    private void AskForQueryParameterValueForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        callback.Invoke(committedValue);
    }

    private void confirmButton_Click(object sender, EventArgs e)
    {
        committedValue = parameterValueEdit.Text;
        Close();
    }
}

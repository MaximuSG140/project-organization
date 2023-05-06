using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.Logging;

namespace ProjectOrganization;

internal class GenericPredefinedQuery : PredefinedQuery
{
    private readonly Logger<GenericPredefinedQuery> logger = 
        new(LoggerFactory.Create(builder => { }));
    public class Parameters
    {
        public string Command
        {
            get; set;
        } = null!;

        public string Description
        {
            get; set;
        } = null!;

        public string[] QueryParameters
        {
            get; set;
        } = null!;
    }

    private DataGridView view = null!;
    private readonly Parameters parameters;
    private MySqlCommand command = null!;
    private int currentParameterIndex = 0;
    private AskForQueryParameterValueForm? parameterInputForm;
    private bool isCanceled = false;

    public string Description => parameters.Description;

    public GenericPredefinedQuery(Parameters parameters)
    {
        this.parameters = parameters;
    }

    public void ExecuteQuery(DataGridView outputView)
    {
        view = outputView;
        var connection = DatabaseConnectionFactory.Instance.DatabaseConnection;
        if (connection.AsMySqlConnection() == null)
        {
            throw new InvalidOperationException("Not MySql database");
        }
        command = connection.AsMySqlConnection()!.CreateCommand();
        command.CommandText = parameters.Command;
        currentParameterIndex = 0;
        parameterInputForm = null;
        isCanceled = false;
        MaybeAskForParameterAndExecuteCommand();
    }

    private void OnGotParameterValue(string? value)
    {
        if (isCanceled)
        {
            return;
        }
        if (value == null)
        {
            return;
        }
        command.Parameters.AddWithValue(parameters.QueryParameters[currentParameterIndex], value);
        currentParameterIndex++;
        MaybeAskForParameterAndExecuteCommand();
    }

    private void ExecuteCommand()
    {
        view.Columns.Clear();
        MySqlDataReader reader;
        try
        {
            reader = command.ExecuteReader();
        }
        catch (Exception exception)
        {
            logger.LogCritical(exception.Message);
            MessageBox.Show("Error executing query", "Error", MessageBoxButtons.OK);
            return;
        }
        for (int i = 0; i < reader.FieldCount; i++)
        {
            DataGridViewColumn column = new()
            {
                Name = reader.GetName(i),
            };

            column.CellTemplate = new DataGridViewTextBoxCell();
            view.Columns.Add(column);
        }

        foreach (var rowUntyped in reader)
        {
            var row = (DbDataRecord)rowUntyped;
            var index = view.Rows.Add();
            var addedRow = view.Rows[index];
            for (var i = 0; i < row.FieldCount; i++)
            {
                var fieldName = row.GetName(i);
                var value = row.GetValue(i);
                addedRow.Cells[fieldName].Value = value;
                addedRow.Cells[fieldName].ReadOnly = true;
            }
        }
        reader.Close();
    }

    private void MaybeAskForParameterAndExecuteCommand()
    {
        if (currentParameterIndex == parameters.QueryParameters.Length)
        {
            ExecuteCommand();
            return;
        }
        parameterInputForm =
            new(parameters.QueryParameters[currentParameterIndex], OnGotParameterValue);
        parameterInputForm.Show();
    }

    public void CancelExecution()
    {
        isCanceled = true;
        parameterInputForm?.Close();
    }
}

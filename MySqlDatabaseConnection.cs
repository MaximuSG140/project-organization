using System.Net;
using MySql.Data.MySqlClient;

namespace ProjectOrganization;

internal class MySqlDatabaseConnection : IDatabaseConnection
{
    private readonly MySqlConnection connection;

    public MySqlDatabaseConnection(IPAddress address, uint port, string userId, string password)
    {
        var builder = new MySqlConnectionStringBuilder
        {
            AllowBatch = false,
            Server = address.ToString(),
            UserID = userId,
            Password = password,
            Port = port,
            Database = "project_organization"
        };
        connection = new MySqlConnection(builder.ToString());
        connection.Open();
    }

    public MySqlDatabaseConnection(string userId, string password)
        : this(new IPAddress(new byte[] { 127, 0, 0, 1 }), 3306u, userId, password)
    {
    }

    public Table<TData> Get<TData>() where TData : class
    {
        return new Table<TData>(connection);
    }

    public void Shutdown()
    {
        connection.Close();
    }
}
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Net;
using MySql.Data.MySqlClient;

namespace ProjectOrganization;

internal class MySqlDatabaseConnection : IDatabaseConnection
{
    private readonly MySqlConnection connection;

    public MySqlDatabaseConnection(IPAddress address, uint port, string userId, string password)
    {
        MySqlConnectionStringBuilder mySqlConnectionBuilder = new() 
        {
            AllowBatch = false,
            Server = address.ToString(),
            UserID = userId,
            Password = password,
            Port = port,
            Database = "project_organization"
        };

        connection = new MySqlConnection(mySqlConnectionBuilder.ToString());
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

    public MySqlConnection? AsMySqlConnection()
    {
        return connection;
    }

    public void Shutdown()
    {
        connection.Close();
    }
}
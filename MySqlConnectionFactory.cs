using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrganization
{
    internal class MySqlConnectionFactory : DatabaseConnectionFactory
    {

        public static void Create()
        {
            SetFactory(new MySqlConnectionFactory());
        }
        private MySqlConnectionFactory()
        {
        }

        public override void CreateDatabaseConnection(IPAddress address, uint port, string userId, string password)
        {
            connection?.Shutdown();
            connection = new MySqlDatabaseConnection(address, port, userId, password);
        }

        public override IDatabaseConnection DatabaseConnection
        {
            get
            {
                if (connection == null)
                {
                    throw new InvalidOperationException();
                }

                return connection;
            }
        }

        public override void ShutdownConnection()
        {
            connection?.Shutdown();
        }

        private MySqlDatabaseConnection? connection = null;
    }
}
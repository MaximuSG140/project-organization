using System.Net;

namespace ProjectOrganization
{
    internal abstract class DatabaseConnectionFactory
    {
        private static DatabaseConnectionFactory? connectionFactory;
        public static DatabaseConnectionFactory GetInstance()
        {
            if (connectionFactory == null)
            {
                throw new NullReferenceException();
            }
            return connectionFactory;
        }

        protected static void SetFactory(DatabaseConnectionFactory factory)
        {
            connectionFactory?.ShutdownConnection();
            connectionFactory = factory;
        }
        public abstract void CreateDatabaseConnection(IPAddress address, uint port, string userId, string password);
        public abstract IDatabaseConnection GetDatabaseConnection();

        public abstract void ShutdownConnection();
    }
}

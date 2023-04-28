using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOrganization
{
    internal class Environment
    {
        public static Environment Instance { get; } = new();

        private Environment()
        {}

        public void SetUp()
        {
            MySqlConnectionFactory.Create();
        }

        public void TearDown()
        {
            DatabaseConnectionFactory.GetInstance().ShutdownConnection();
        }
    }
}

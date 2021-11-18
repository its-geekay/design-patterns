using System.Data.Common;
using System.Data.OracleClient;

namespace AbstractFactory
{
    internal class OracleClientFactory : IDatabaseFactory
    {
        public DbCommand GetCommand()
        {
            return new OracleCommand();
        }

        public DbConnection GetConnection()
        {
            return new OracleConnection();
        }

        public DbParameter GetParameter()
        {
            return new OracleParameter();
        }
    }
}

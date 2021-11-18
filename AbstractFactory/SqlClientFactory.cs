using System.Data.Common;
using System.Data.SqlClient;

namespace AbstractFactory
{
    internal class SqlClientFactory : IDatabaseFactory
    {
        public DbCommand GetCommand()
        {
            return new SqlCommand();
        }

        public DbConnection GetConnection()
        {
            return new SqlConnection();
        }

        public DbParameter GetParameter()
        {
            return new SqlParameter();
        }
    }
}
    
using System.Data;
using System.Data.Common;

namespace AbstractFactory
{
    internal class DatabaseHelper
    {
        private IDatabaseFactory factory;

        public DatabaseHelper(IDatabaseFactory dbFactory)
        {
            this.factory = dbFactory;
        }

        public DbDataReader ExecuteSelect(string query)
        {
            DbConnection conn = factory.GetConnection();
            conn.ConnectionString = "";
            DbCommand cmd = factory.GetCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            conn.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}

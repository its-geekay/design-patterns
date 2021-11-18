using System.Data.Common;

namespace AbstractFactory
{
    internal interface IDatabaseFactory
    {
        DbConnection GetConnection();
        DbCommand GetCommand();
        DbParameter GetParameter();
    }
}

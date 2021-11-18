using AbstractFactory;
using System.Data.Common;

IDatabaseFactory? factory;

string factoryType = "sqlclient";

if (factoryType == "sqlclient")
{
    factory = new SqlClientFactory();
}
else
{
    factory = new OracleClientFactory();
}

DatabaseHelper helper = new DatabaseHelper(factory);

DbDataReader reader = helper.ExecuteSelect("select * from customers");

Console.WriteLine(reader);

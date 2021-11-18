namespace FactoryMethod
{
    internal class DatabaseLogger : ILogger
    {
        public void log(string message)
        {
            // Write logic to log to database.
            Console.WriteLine(message);
        }
    }
}

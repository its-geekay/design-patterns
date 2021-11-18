namespace FactoryMethod
{
    internal class ConsoleLogger : ILogger
    {
        public void log(string message)
        {
            // Write logic to log to console.
            Console.WriteLine(message);
        }
    }
}

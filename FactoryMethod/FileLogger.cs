namespace FactoryMethod
{
    internal class FileLogger : ILogger
    {
        public void log(string message)
        {
            // Write logic to log to file.
            Console.WriteLine(message);
        }
    }
}

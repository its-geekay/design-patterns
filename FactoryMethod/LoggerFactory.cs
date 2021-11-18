namespace FactoryMethod
{
    internal class LoggerFactory
    {
        /// <summary>
        /// Factory Method.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public ILogger GetLogger(int value)
        {
            if(value == 1)
            {
                return new FileLogger();
            }
            else if(value == 2)
            {
                return new DatabaseLogger();    
            }
            else
            {
                return new ConsoleLogger();
            }
        }
    }
}

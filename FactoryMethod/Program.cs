using FactoryMethod;

LoggerFactory factory = new LoggerFactory();
ILogger logger = factory.GetLogger(3);
logger.log("Logging to console...");

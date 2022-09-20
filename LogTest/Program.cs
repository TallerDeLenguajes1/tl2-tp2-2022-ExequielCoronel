using NLog;
class Program{
    
    static void Main(string[] args)
    {
        Logger logger = LogManager.GetCurrentClassLogger();  
        logger.Info("Mensaje de informacion");
        logger.Debug("Mensaje de debug");
    }
}

using System;

namespace InterfaceAndExtensibility
{
    public class ConsoleLogger : ILogger
    {

        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
        }
    }

   /* private readonly ILogger _logger;

    // now i can use this any where whitout worring about coupling
    public DbMigrater(ILogger logger)
    {
        // dependancy injection  
        _logger = logger;
    }
    public void Migrite()
    {
        _logger.LogInfo("Migration started at {0}" + DateTime.Now);
        //Console.WriteLine("Migration started at {0}", DateTime.Now);

        // Details of migrating the database

        _logger.LogInfo("Migration finished at {0}" + DateTime.Now);
        //Console.WriteLine("Migration finished at {0}", DateTime.Now);
    }*/
}

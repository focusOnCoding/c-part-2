using System;

namespace InterfaceAndExtensibility
{
    public class DbMigrator
    {
        
        private readonly ILogger _logger;// this makes my code extendeble

        // now i can use this any where whitout worring about coupling
        public DbMigrator(ILogger logger)
        {
            // dependancy injection  
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration started at {0}" + DateTime.Now);
            //Console.WriteLine("Migration started at {0}", DateTime.Now);

            // Details of migrating the database

            _logger.LogInfo("Migration finished at {0}" + DateTime.Now);
            //Console.WriteLine("Migration finished at {0}", DateTime.Now);
        }
    }
}
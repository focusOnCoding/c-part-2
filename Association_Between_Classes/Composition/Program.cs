using System;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigration = new DBMigrater(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);
            dbMigration.Migrate();
            Console.WriteLine("Hello World!");
        }
    }
}
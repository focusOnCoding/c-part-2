namespace InterfaceAndExtensibility
{

    partial class Program
    {

        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new FileLogger("C:\\Project\\logs.txt"));
            dbMigrator.Migrate(); 
        }
    }
}
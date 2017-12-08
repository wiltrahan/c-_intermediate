using System.Collections.Generic;

namespace Extensibility
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();
        }
    }
}
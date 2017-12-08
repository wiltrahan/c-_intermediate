using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace PolymorphismExercise1
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            const string connectionString = "Open Sesame.";
            const string closingString = "Database Closed.";
            
            var sql = new SqlConnection();
            sql.Opened(connectionString);
            sql.Closed(closingString);
            
            var oracle = new OracleConnection();
            oracle.Opened(connectionString);
            oracle.Closed(closingString);
            
        }
    }
}
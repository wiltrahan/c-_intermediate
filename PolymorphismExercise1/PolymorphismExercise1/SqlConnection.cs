using System;

namespace PolymorphismExercise1
{
    public class SqlConnection : DbConnection
    {
        public override void Opened(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("No connection string supplied.");
            }
            
            Console.WriteLine("Sql Opened");
        }

        public override void Closed(string closingString)
        {
            if (String.IsNullOrWhiteSpace(closingString))
            {
                throw new InvalidOperationException("No closing string supplied.");
            }
            Console.WriteLine("Sql Closed");
        }
    }
}
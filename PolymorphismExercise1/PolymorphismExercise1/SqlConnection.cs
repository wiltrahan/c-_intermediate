using System;

namespace PolymorphismExercise1
{
    public class SqlConnection : DbConnection
    {
        public override void Opened(string connectionString)
        {
            if (connectionString == null)
            {
                throw new InvalidOperationException("No connection string supplied.");
            }
            
            Console.WriteLine("Sql Opened");
        }

        public override void Closed(string closingString)
        {
            if (closingString == null)
            {
                throw new InvalidOperationException("No closing string supplied.");
            }
            Console.WriteLine("Sql Closed");
        }
    }
}
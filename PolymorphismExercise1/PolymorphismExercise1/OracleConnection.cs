using System;

namespace PolymorphismExercise1
{
    public class OracleConnection : DbConnection
    {
        public override void Opened(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("No opening string supplied.");
            }
            Console.WriteLine("Oracle Opened");
            
        }

        public override void Closed(string closingString)
        {
            if (String.IsNullOrWhiteSpace(closingString))
            {
                throw new InvalidOperationException("No closing string supplied.");
            }
            Console.WriteLine("Oracle Closed.");
        }
    }
}
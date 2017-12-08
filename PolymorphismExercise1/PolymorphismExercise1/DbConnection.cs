using System;

namespace PolymorphismExercise1
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public abstract void Opened(string connectionString);
        public abstract void Closed(string closingString);


    }
}
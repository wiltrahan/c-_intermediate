using System;

namespace StopWatchExercise
{
    public class Stopwatch
    {
        private DateTime _startTime = new DateTime();
        private DateTime _stopTime = new DateTime();

        public void Start()
        {
            _startTime = DateTime.Now;
        }

        public void Stop()
        {
            _stopTime = DateTime.Now;
        }

        public TimeSpan Duration()
        {
            return _stopTime - _startTime;
        }

    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            var isStopped = true;
            while(isStopped)
            {
                Console.WriteLine("Press 'Enter' to start, or 'quit' to exit program");
                var begin = Console.ReadLine();
                Stopwatch stopwatch = new Stopwatch();

                if (String.IsNullOrWhiteSpace(begin))
                {
                    stopwatch.Start();
                    isStopped = false;
                }
                else if(begin == "quit")
                {
                    Console.WriteLine("\nGoodbye");
                    return;
                }

                Console.WriteLine("Press 'Enter' to stop");
                var end = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(end))
                {
                    stopwatch.Stop();
                    isStopped = true;
                }
                Console.WriteLine("Time Elapsed: {0:mm\\:ss\\:fff}", stopwatch.Duration());
            }
        }
    }
}

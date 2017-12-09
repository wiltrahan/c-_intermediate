using System;

namespace InterfacesExercise
{
    public class Video
    {
        public static string Name { get; set; }
        public static DateTime Time { get; set; }

        public Video(string name, DateTime time)
        {
            Name = name;
            Time = time;   
        }
    }
}
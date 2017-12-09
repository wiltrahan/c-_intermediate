using System;


namespace InterfacesExercise
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var video = new Video(name: "Fun Time Video", time: DateTime.Now);
            var workflow = new Workflow(new Messages());
            
            workflow.Upload(Video.Name, Video.Time);
        }
    }
}
using System;

namespace InterfacesExercise
{
    public class Workflow
    {
        private static IExecute _execute;

        public Workflow(IExecute execute)
        {
            _execute = execute;
        }

        public void Upload(string name, DateTime time)
        {
            _execute.LogInfo(name + " began uploading at " + time);
            _execute.LogThirdParty(name + " is being processed by AWS, it has been in process since " + time);
            _execute.DbChange("The status of " + name + " is: 'In Process', " +
                              "no further information is available at this time.");  
        }    
    }
}
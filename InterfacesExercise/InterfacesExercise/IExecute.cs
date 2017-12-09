namespace InterfacesExercise
{
    public interface IExecute
    {
        void LogInfo(string message);
        void LogThirdParty(string message);
        void DbChange(string message);
    }
}
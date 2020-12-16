namespace InterfaceAndExtensibility
{
    // change code without changing code but adding new classes with new implemantation
    // create a interface that will make it easy for me to change my code to
    // log to a file in the future
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }
}

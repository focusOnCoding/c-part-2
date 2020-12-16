using System.IO;

namespace InterfaceAndExtensibility
{
    partial class Program
    {
        // now i want to change the logs to consle to log to a file thats easy using interfaces
        public class FileLogger : ILogger
        {
            private readonly string _path;

            public void LogError(string message)
            {
                // write to file with this method
                // dispose of file when done {using}
                /*using(var streamWriter = new StreamWriter(_path, true)) // close when done or any error
                {
                    streamWriter.WriteLine("Error: " + message);
                }*/
                Log(message, "Error");
                
            }

            // constructor with file name
            public FileLogger(string path)
            {
                _path = path;
            }

            public void LogInfo(string message)
            {
                Log(message, "Info"); 
            }

            // so i dont copy and past code or repeat myself i can 
            private void Log(string message, string messageType)
            {
                using (var streamWriter = new StreamWriter(_path, true)) // close when done or any error
                {
                    streamWriter.WriteLine(messageType + ": " + message); // now i can reuse this in both inistances {LogError & LogInfo}
                }
            }
        }
    }
}
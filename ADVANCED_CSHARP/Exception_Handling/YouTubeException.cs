using System;

namespace Exception_Handling
{
    // creat custome error handles
    public class YouTubeException : Exception
    {
        public YouTubeException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}

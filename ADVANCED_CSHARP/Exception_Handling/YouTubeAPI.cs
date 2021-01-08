using System;
using System.Collections.Generic;

namespace Exception_Handling
{
     public class YouTubeAPI
    {
        public List<Video> GetVideo(string user)
        {
            try
            {
                // Access YouTube web service
                // Read the data
                // Create a list of video object
            }
            catch (Exception)
            {
                // loh errors   
                throw new YouTubeException("Could not fetch the videos from YouTube ", ex);
            }
            return new List<Video>();
        }
    }
}

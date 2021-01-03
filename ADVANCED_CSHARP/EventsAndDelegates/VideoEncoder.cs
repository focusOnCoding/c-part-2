using System;
using System.Threading;

namespace EventsAndDelegates
{
    public class videoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        // 1- Define a delegate
        // 2- Define an event based on that delegate
        // 3- Raise the event

        // 1-
        public delegate void VideoEncodedEventHandler(object source, /*EventArgs args*/ videoEventArgs args);
        // 2-
        public event VideoEncodedEventHandler VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            // ress the event
            OnVideoEncoded(video);
        }

        // 3-
        protected virtual void OnVideoEncoded(Video video)
        {
            // check if i have any subscribies
            if (VideoEncoded != null)
            {
                VideoEncoded(this, new videoEventArgs() { Video = video });
            }
        }
    }
}

using System;

namespace EventsAndDelegates
{
    // responseble for sending text massege
    public class MessageService
    {
        public void OnVideoEncoded(object source, videoEventArgs args)
        {
            Console.WriteLine("MessageService: Sending a text message..." + args.Video.Title);
        }
    }
}

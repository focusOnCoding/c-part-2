
using System.Collections;
using System.Collections.Generic;

namespace InterfacesAndPolymorphism
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> _notificationChannels; 

        public VideoEncoder()
        {
            _notificationChannels = new List<INotificationChannel>();
        }

        // reduce the amount change in code
        public void Encode(Video video)
        {
            // Video encoding logic     
            // ...

            foreach (var channel in _notificationChannels)
                channel.Send(new Message());
        }

        // this is what ill use from the outside to add channel
        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}
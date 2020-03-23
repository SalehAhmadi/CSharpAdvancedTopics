using System;

namespace AdvancedTopics.EventHandlers
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Sending Message " + e.Video.Title);
        }
    }
}

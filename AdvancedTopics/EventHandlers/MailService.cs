using System;

namespace AdvancedTopics.EventHandlers
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Sending Mail " + e.Video.Title);
        }
    }

}

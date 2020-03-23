using AdvancedTopics.EventHandlers.Samples;
using System;
using System.Threading;

namespace AdvancedTopics.EventHandlers
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        //1- Define a Delegate
        //2- Define an event based on that delegate
        //3- Raise the event


        ///public delegate void VideoEncodedEventHandler(object source, VideoEventArgs eventArgs);
        public event EventHandler<VideoEventArgs> videoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (videoEncoded != null)
            {
                videoEncoded(this, new VideoEventArgs() { Video = video });
            }
        }
    }
}

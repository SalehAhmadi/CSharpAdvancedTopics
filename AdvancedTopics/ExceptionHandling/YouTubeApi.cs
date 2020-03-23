using AdvancedTopics.EventHandlers.Samples;
using System;
using System.Collections.Generic;

namespace AdvancedTopics.ExceptionHandling
{
    public class YouTubeApi
    {
        public List<Video> GetVideos(string user)
        {
            try
            {
                throw new Exception("Low Level Exception");
            }
            catch (Exception ex)
            {
                throw new YouTubeException("Could Not Load The Videos", ex);
            }
        }
    }
}

using System;

namespace AdvancedTopics.Delegates.Samples
{
    public class PhotoProcessor
    {
        //public delegate void PhotoFilterHandler(Photo photo);
        public void Process(string path, Action<Photo> filterHandler)//PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);
            filterHandler(photo);

            photo.Save();
        }
    }
}

using AdvancedTopics;
using AdvancedTopics.Delegates.Samples;
using AdvancedTopics.Generics.Samples;
using System;
namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var photo = new PhotoProcessor();
            var filters = new PhotoFilters();
            //PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;
            photo.Process("test", filterHandler);

            var numbers = new Generic<int>();
            numbers.Add(10);

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1", new Book());

            var NUMBER = new AdvancedTopics.Nullable<int>();
            Console.WriteLine("Has Value? " + NUMBER.HasValue);
            Console.WriteLine("Value: " + NUMBER.GetValueOrDefault());
            //Or You can use System.Nullable for this purpose.
        }

        static void RemoveRedEyeFilter(Photo photo)
        {
            Console.WriteLine("Remove RedEye");
        }
    }
}

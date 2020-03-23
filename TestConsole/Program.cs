using AdvancedTopics;
using AdvancedTopics.Delegates.Samples;
using AdvancedTopics.EventHandlers;
using AdvancedTopics.EventHandlers.Samples;
using AdvancedTopics.Generics.Samples;
using System;
namespace TestConsole
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Events
            var video = new Video() { Title = "Video Title 1" };
            var videoEncoder = new VideoEncoder(); /// Publisher
            var mailService = new MailService();// subscriber
            var messageService = new MessageService();
            videoEncoder.videoEncoded += mailService.OnVideoEncoded;
            videoEncoder.videoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
            // =>
            const int factor = 5;
            Func<int, int> multipler = n => n * factor;
            Console.WriteLine(multipler(5));

            var books = new BookRepository().GetBooks();
            //var cheapBooks = books.FindAll(IsCheaperThan10Dollars);
            var cheapBooks = books.FindAll(b => b.Price < 10);
            foreach (var book in cheapBooks)
                Console.WriteLine(book.Title);
            //Delegates
            var photo = new PhotoProcessor();
            var filters = new PhotoFilters();
            //PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += RemoveRedEyeFilter;
            photo.Process("test", filterHandler);
            //Generics
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

        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
    }
}

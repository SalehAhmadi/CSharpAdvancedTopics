using AdvancedTopics;
using AdvancedTopics.Samples;
using System;
namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Generic<int>();
            numbers.Add(10);

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1", new Book());

            var NUMBER = new AdvancedTopics.Nullable<int>();
            Console.WriteLine("Has Value? " + NUMBER.HasValue);
            Console.WriteLine("Value: " + NUMBER.GetValueOrDefault());
            //Or You can use System.Nullable for this purpose.
        }
    }
}

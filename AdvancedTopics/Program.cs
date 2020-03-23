namespace AdvancedTopics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new Generic<int>();
            numbers.Add(10);

            var dictionary = new GenericDictionary<string, int>();
            dictionary.Add("1", 1);
        }
    }
}

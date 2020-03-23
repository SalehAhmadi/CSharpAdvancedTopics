using System.Collections.Generic;

namespace AdvancedTopics.Generics.Samples
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book> {
            new Book(){Title = "t1", Price = 5 },
            new Book(){Title = "t2", Price = 7 },
            new Book(){Title = "t3", Price = 43 }
            };
        }
    }
}

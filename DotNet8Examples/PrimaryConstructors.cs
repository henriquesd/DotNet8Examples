namespace DotNet8Examples
{
    public static class PrimaryConstructors
    {
        #region Class example

        // Primary Constructor example;
        public class Book(int id, string title, IEnumerable<decimal> ratings)
        {
            // It's also possible to have multiple constructors, and for that, it's necessary to use the this(…) keyword (which will call the main/primary constructor);
            public Book(int id, string title) : this(id, title, Enumerable.Empty<decimal>()) { }
            
            public Book() : this(99, "Demo book") { }

            // Id and Title are are read-only, and the values will be received via Primary Constructor;
            public int Id => id;
            public string Title => title.Trim();

            // In the Pages property it will be possible to read and write value;
            public int Pages { get; set; }

            public decimal AverageRating => ratings.Any() ? ratings.Average() : 0m;
        }

        // Default Constructor example;
        public class BookDefault
        {
            public int Id { get; }
            public string Title { get; }
            public int Pages { get; set; }
            private readonly List<decimal> ratings = new List<decimal>();
            public decimal? AverageRating => ratings.Any() ? ratings.Average() : 0m;

            public BookDefault(int id, string title, IEnumerable<decimal>? rating = null)
            {
                Id = id;
                Title = title;

                if (rating?.Any() == true)
                {
                    ratings.AddRange(rating);
                }
            }
        }
        #endregion

        #region Dependency Injection example
        public interface IBookRepository
        {
            Task<List<Book>> GetAll();
        }

        // Dependency Injection with Primary Constructor example;
        public class BookService(IBookRepository bookRepository)
        {
            public async Task<IEnumerable<Book>> GetAll()
            {
                return await bookRepository.GetAll();
            }
        }

        // Default Dependency Injection example;
        public class BookServiceDefault
        {
            private readonly IBookRepository _bookRepository;

            public BookServiceDefault(IBookRepository bookRepository)
            {
                _bookRepository = bookRepository;
            }

            public async Task<IEnumerable<Book>> GetAll()
            {
                return await _bookRepository.GetAll();
            }
        }
        #endregion
    }
}

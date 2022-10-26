using modernBookstoreForCD.Models;

namespace modernBookstoreForCD.Managers
{
    public class BooksManager
    {
        private static int _nextId = 1;
        private static readonly List<Book> data = new()
        {
            new Book {   Id = _nextId++, Title = "The Hobbit", Price = 10 },
            new Book { Id=_nextId++, Title="Prince", Price=12}
        };
        public List<Book> GetAll()
        {
            return data;
        }
        public Book? GetById(int id)
        {
            return data.FirstOrDefault(b => b.Id == id);
        }

        public Book Add(Book book)
        {
            book.Id = _nextId++;
            data.Add(book);
            return book;
        }


    }
}

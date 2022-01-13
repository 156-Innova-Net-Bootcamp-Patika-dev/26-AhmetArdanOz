using LibraryApi.Models;
using LibraryApi.Repository;

namespace LibraryApi.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly LibraryContext _context;

        public BookRepository(LibraryContext context)
        {
            _context = context;
        }
        public BookInfo GetById(int Id)
        {
            var data = _context.BookInfos.Find(Id);
            return data;
        }

        public void CreateBook(BookInfo book)
        {
            _context.BookInfos.Add(book);
            _context.SaveChanges();
        }

        public void DeleteById(int Id)
        {
            var book = _context.BookInfos.Find(Id);

            _context.BookInfos.Remove(book);
            _context.SaveChanges();
        }

        public void UpdateBook(BookInfo kitapObj)
        {
            _context.Update(kitapObj);
            _context.SaveChanges();
        }

    }
}

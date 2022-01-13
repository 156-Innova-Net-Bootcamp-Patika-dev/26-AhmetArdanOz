using LibraryApi.Models;

namespace LibraryApi.Repository
{
    public interface IBookRepository
    {
        BookInfo GetById(int Id);

        void CreateBook(BookInfo book);

        void DeleteById(int Id);

        void UpdateBook(BookInfo book);

    }
}

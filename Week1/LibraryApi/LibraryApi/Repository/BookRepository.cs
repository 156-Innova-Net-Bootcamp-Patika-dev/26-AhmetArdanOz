using LibraryApi.Models;
using LibraryApi.Repository;

namespace LibraryApi.Repository
{
    public class BookRepository : IBookRepository
    {

        public BookInfo GetById(int Id)
        {
            var data = LibraryData.Where(x => x.Id == Id).FirstOrDefault();
            return data;
        }

        public void CreateBook(BookInfo book)
        {
            LibraryData.Add(book);
        }

        public void DeleteById(int Id)
        {
            var data = LibraryData.Where(x => x.Id == Id).FirstOrDefault();
            LibraryData.Remove(data);
        }

        public void UpdateBook(BookInfo book)
        {
            var result = LibraryData.FirstOrDefault(x => x.Id == book.Id);
            result.AuthorName = book.AuthorName;
            result.BookName = book.BookName;
            result.Page = book.Page;
        }

        // static Datas
        public  List<BookInfo> LibraryData = new List<BookInfo>()
        {
            new BookInfo
            {
                Id = 1,
                BookName = "Fareler ve İnsanlar",
                AuthorName = "John Steinbeck",
                Page = 107
            },
            new BookInfo
            {
                Id = 2,
                BookName = "Dublinliler",
                AuthorName = "James Joyce",
                Page = 201
            },
            new BookInfo
            {
                Id = 3,
                BookName = "Kırmızı Pazartesi",
                AuthorName = "Gabriel Garcia Marquez",
                Page = 300
            },
            new BookInfo
            {
                Id = 4,
                BookName = "Kürk Mantolu Madonna",
                AuthorName = "Sabahattin Ali",
                Page = 250
            },
            new BookInfo
            {
                Id = 5,
                BookName = "Pardayanlar",
                AuthorName = "Michel Zevaco",
                Page = 350
            }
        };


    }
}

using Microsoft.EntityFrameworkCore;

namespace LibraryApi.Models

{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options):base(options)
        {
        }

        public DbSet<BookInfo> BookInfos { get; set; }

        
        // static Datas
        public static List<BookInfo> LibraryData = new List<BookInfo>()
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

using System.ComponentModel.DataAnnotations;

namespace LibraryApi.Models
{
    public class BookInfo
    {        
        public int Id { get; set; }
        public string? BookName { get; set; }
        public string? AuthorName { get; set; }
        public int Page { get; set; }
        
    }
}

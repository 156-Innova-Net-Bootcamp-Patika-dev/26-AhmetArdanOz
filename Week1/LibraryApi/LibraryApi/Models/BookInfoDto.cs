using System.ComponentModel.DataAnnotations;

namespace LibraryApi.Models
{
    public class BookInfoDto
    {
        [MaxLength(50)]
        public string BookName { get; set; }
        
        [MaxLength(50)]
        public string AuthorName { get; set; }
        
        public int Page { get; set; }

    }
}

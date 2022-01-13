using LibraryApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryApiController : ControllerBase
    {
        private readonly LibraryContext _context;
        public LibraryApiController(LibraryContext context)
        {
            _context = context;
        }

        [HttpGet("{Id}")]
        public BookInfo GetById(int Id)
        {
            var data = _context.BookInfos.Find(Id);
            return data;
        }
    }
}

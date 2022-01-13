using LibraryApi.Models;
using LibraryApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryApiController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        public LibraryApiController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet("{Id}")]
        public BookInfo GetById(int Id)
        {
            var data = _bookRepository.GetById(Id);
            return data;
        }

        [HttpPost]
        public void AddBook(BookInfo book)
        {
            _bookRepository.CreateBook(book);
        }

        [HttpPut]
        public void UpdateBook(BookInfo book)
        {
            _bookRepository.UpdateBook(book);
        }

        [HttpDelete]
        public void DeleteBook(int Id)
        {
            _bookRepository.DeleteById(Id);
        }

    }
}

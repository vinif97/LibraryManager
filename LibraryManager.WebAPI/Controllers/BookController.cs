using LibraryManager.Application.Interfaces.Services;
using LibraryManager.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("{publisherName}")]
        public async Task<IActionResult> GetBookByPublisherName([FromRoute]string publisherName)
        {
            Publisher publisher = await _bookService.GetBooksByPublisherName(publisherName);

            if (publisher.Books is not null && !publisher.Books.Any())
                return NotFound("No books registered with this publisher");

            return Ok(publisher);
        }


    }
}

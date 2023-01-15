using LibraryManager.Application.DTOs;
using LibraryManager.Application.ErrorHandler;
using LibraryManager.Application.Interfaces.Services;
using LibraryManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManager.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : ControllerBase
    {
        private readonly IBookService _bookService;

        public PublisherController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPublishers()
        {
            var publishers = await _bookService.GetPublishers();
            return Ok(publishers);
        }

        [HttpPost]
        public async Task<IActionResult> AddPublisher(PublisherAddDTO publisher)
        {
            DatabaseOperationResult operationResult = await _bookService.AddPublisher(publisher);

            if (!operationResult.IsSuccess)
                return BadRequest(operationResult.Errors);

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePublisher(PublisherUpdateGetDTO publisher)
        {
            DatabaseOperationResult operationResult = await _bookService.UpdatePublisher(publisher);

            if (!operationResult.IsSuccess && operationResult.Errors.Contains("Publisher doesn't exist"))
                return NotFound(operationResult.Errors);
            if (!operationResult.IsSuccess)
                return BadRequest(operationResult.Errors);

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> DeletepPublisher(string publisherName)
        {
            await _bookService.DeletePublisher(publisherName);

            return NoContent();
        }
    }
}

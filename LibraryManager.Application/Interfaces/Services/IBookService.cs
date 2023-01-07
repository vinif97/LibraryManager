using LibraryManager.Application.DTOs;
using LibraryManager.Application.ErrorHandler;
using LibraryManager.Domain.Models;
using System.Threading.Tasks;

namespace LibraryManager.Application.Interfaces.Services
{
    public interface IBookService
    {
        Task<Publisher> GetBooksByPublisherName(string publisherName);
        Task<IEnumerable<Publisher>> GetPublishers();
        Task<DatabaseOperationResult> AddPublisher(PublisherAddDTO publisher);
        Task<DatabaseOperationResult> UpdatePublisher(PublisherUpdateDTO publisherDTO);
        Task DeletePublisher(string publisherName);
    }
}

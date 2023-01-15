using LibraryManager.Application.DTOs;
using LibraryManager.Application.ErrorHandler;
using LibraryManager.Domain.Models;
using System.Threading.Tasks;

namespace LibraryManager.Application.Interfaces.Services
{
    public interface IBookService
    {
        Task<Publisher?> GetBooksByPublisherName(string publisherName);
        Task<IEnumerable<PublisherUpdateGetDTO>> GetPublishers();
        Task<DatabaseOperationResult> AddPublisher(PublisherAddDTO publisher);
        Task<DatabaseOperationResult> UpdatePublisher(PublisherUpdateGetDTO publisherDTO);
        Task DeletePublisher(string publisherName);
    }
}

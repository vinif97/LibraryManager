using LibraryManager.Domain.Models;

namespace LibraryManager.Domain.Interfaces.Repositories
{
    public interface IPublisherRepository : IRepository<Publisher>
    {
        Task<Publisher?> GetByPublisherName(string publisherName);
    }
}

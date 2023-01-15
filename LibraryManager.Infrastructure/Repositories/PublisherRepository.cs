using LibraryManager.Domain.Interfaces.Repositories;
using LibraryManager.Domain.Models;
using LibraryManager.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Infrastructure.Repositories
{
    public class PublisherRepository : Repository<Publisher>, IPublisherRepository
    {
        public PublisherRepository(LibraryContext context) : base(context)
        {
        }

        public async Task<Publisher?> GetByPublisherName(string publisherName)
        {
            return await _context.Publishers.FirstOrDefaultAsync(x => x.PublisherName == publisherName);
        }

        public async Task<Publisher?> GetPublisherByNameWithBooks(string publisherName)
        {
            return await _context.Publishers.Select(publisher => new Publisher
            {
                PublisherId = publisher.PublisherId,
                PublisherName = publisher.PublisherName,
                Books = publisher.Books
            }).FirstOrDefaultAsync(x => x.PublisherName == publisherName);
        }
    }
}

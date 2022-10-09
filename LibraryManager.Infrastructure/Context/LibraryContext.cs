using LibraryManager.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Infrastructure.Context
{
    public class LibraryContext : IdentityDbContext<User>
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        { }

        DbSet<Address> Addresses { get; set; }
        DbSet<Author> Authors { get; set; }
        DbSet<Book> Books { get; set; }
        DbSet<BookItem> Bookitems { get; set; }
        DbSet<BookLending> BookLendings { get; set; }
        DbSet<BookReservation> BookReservations { get; set; }
        DbSet<Publisher> Publishers { get; set; }
        DbSet<Member> Members { get; set; }
        DbSet<Librarian> Librarians { get; set; }
    }
}

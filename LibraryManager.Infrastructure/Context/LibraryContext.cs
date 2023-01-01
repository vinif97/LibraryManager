using LibraryManager.Domain.Models;
using LibraryManager.Infrastructure.Context.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManager.Infrastructure.Context
{
    public class LibraryContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        { }

        DbSet<Address>? Addresses { get; set; }
        DbSet<Author>? Authors { get; set; }
        DbSet<Book>? Books { get; set; }
        DbSet<BookItem>? BookItems { get; set; }
        DbSet<BookLending>? BookLendings { get; set; }
        DbSet<BookReservation>? BookReservations { get; set; }
        DbSet<City>? Cities { get; set; }
        DbSet<Country>? Countries { get; set; }
        DbSet<Librarian>? Librarians { get; set; }
        DbSet<Library>? Libraries { get; set; }
        DbSet<Member>? Members { get; set; }
        DbSet<Publisher>? Publishers { get; set; }
        DbSet<State>? States { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(LibraryContext).Assembly);
        }
    }
}

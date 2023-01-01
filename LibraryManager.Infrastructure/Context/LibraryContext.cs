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

        public DbSet<Address> Addresses => Set<Address>();
        public DbSet<Author> Authors => Set<Author>();
        public DbSet<Book> Books => Set<Book>();
        public DbSet<BookItem> BookItems => Set<BookItem>();
        public DbSet<BookLending> BookLendings => Set<BookLending>();
        public DbSet<BookReservation> BookReservations => Set<BookReservation>();
        public DbSet<City> Cities => Set<City>();
        public DbSet<Country> Countries => Set<Country>();
        public DbSet<Librarian> Librarians => Set<Librarian>();
        public DbSet<Library> Libraries => Set<Library>();
        public DbSet<Member> Members => Set<Member>();
        public DbSet<Publisher> Publishers => Set<Publisher>();
        public DbSet<State> States => Set<State>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(LibraryContext).Assembly);
        }
    }
}

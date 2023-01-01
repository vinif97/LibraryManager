﻿// <auto-generated />
using System;
using LibraryManager.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryManager.Infrastructure.Migrations
{
    [DbContext(typeof(LibraryContext))]
    partial class LibraryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<int>("AuthorsAuthorId")
                        .HasColumnType("int");

                    b.Property<int>("BooksBookId")
                        .HasColumnType("int");

                    b.HasKey("AuthorsAuthorId", "BooksBookId");

                    b.HasIndex("BooksBookId");

                    b.ToTable("AuthorBook");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"), 1L, 1);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Complement")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<short>("Number")
                        .HasPrecision(5)
                        .HasColumnType("smallint");

                    b.Property<string>("Reference")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Zipcode")
                        .HasMaxLength(9)
                        .HasColumnType("char(9)");

                    b.HasKey("AddressId");

                    b.HasIndex("CityId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"), 1L, 1);

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"), 1L, 1);

                    b.Property<byte>("Category")
                        .HasColumnType("tinyint");

                    b.Property<string>("PublishedYear")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("char(4)");

                    b.Property<int>("PublisherId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("BookId");

                    b.HasIndex("PublisherId");

                    b.HasIndex("Title")
                        .IsUnique();

                    b.ToTable("Books");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.BookItem", b =>
                {
                    b.Property<int>("BookItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookItemId"), 1L, 1);

                    b.Property<string>("Barcode")
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsReferenceOnly")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<bool?>("IsVirtual")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<byte>("Language")
                        .HasColumnType("tinyint");

                    b.Property<int>("LibraryId")
                        .HasColumnType("int");

                    b.Property<decimal>("PricePerDay")
                        .HasPrecision(10, 2)
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("BookItemId");

                    b.HasIndex("BookId");

                    b.HasIndex("LibraryId");

                    b.ToTable("BookItems");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.BookLending", b =>
                {
                    b.Property<int>("BookLendingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookLendingId"), 1L, 1);

                    b.Property<int>("BookItemId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MemberId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BookLendingId");

                    b.HasIndex("BookItemId")
                        .IsUnique();

                    b.HasIndex("MemberId");

                    b.ToTable("BookLendings");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.BookReservation", b =>
                {
                    b.Property<int>("BookReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookReservationId"), 1L, 1);

                    b.Property<int?>("BookItemId")
                        .HasColumnType("int");

                    b.Property<int>("BookReservationStatus")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BookReservationId");

                    b.HasIndex("BookItemId");

                    b.ToTable("BookReservations");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityId"), 1L, 1);

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StateId")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"), 1L, 1);

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.Librarian", b =>
                {
                    b.Property<int>("LibrarianId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LibrarianId"), 1L, 1);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LibrarianId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Librarians");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.Library", b =>
                {
                    b.Property<int>("LibraryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LibraryId"), 1L, 1);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LibraryId");

                    b.HasIndex("AddressId");

                    b.ToTable("Libraries");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.Member", b =>
                {
                    b.Property<int>("MemberId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MemberId"), 1L, 1);

                    b.Property<int>("TotalCheckoutBooks")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("MemberId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Members");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.Publisher", b =>
                {
                    b.Property<int>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PublisherId"), 1L, 1);

                    b.Property<string>("PublisherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PublisherId");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StateId"), 1L, 1);

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateId");

                    b.HasIndex("CountryId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<int>("AccountStatus")
                        .HasColumnType("int");

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("LibraryManager.Domain.Models.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsAuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManager.Domain.Models.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.Address", b =>
                {
                    b.HasOne("LibraryManager.Domain.Models.City", "City")
                        .WithMany("Addresses")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.Book", b =>
                {
                    b.HasOne("LibraryManager.Domain.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.BookItem", b =>
                {
                    b.HasOne("LibraryManager.Domain.Models.Book", "Book")
                        .WithMany("BookItems")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManager.Domain.Models.Library", "Library")
                        .WithMany("BookItems")
                        .HasForeignKey("LibraryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Library");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.BookLending", b =>
                {
                    b.HasOne("LibraryManager.Domain.Models.BookItem", "BookItem")
                        .WithOne("BookLending")
                        .HasForeignKey("LibraryManager.Domain.Models.BookLending", "BookItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManager.Domain.Models.Member", "Member")
                        .WithMany("CheckedOutBooks")
                        .HasForeignKey("MemberId");

                    b.Navigation("BookItem");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.BookReservation", b =>
                {
                    b.HasOne("LibraryManager.Domain.Models.BookItem", "BookItem")
                        .WithMany("BookReservation")
                        .HasForeignKey("BookItemId");

                    b.Navigation("BookItem");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.City", b =>
                {
                    b.HasOne("LibraryManager.Domain.Models.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId");

                    b.Navigation("State");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.Librarian", b =>
                {
                    b.HasOne("LibraryManager.Domain.Models.User", "User")
                        .WithOne("Librarian")
                        .HasForeignKey("LibraryManager.Domain.Models.Librarian", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.Library", b =>
                {
                    b.HasOne("LibraryManager.Domain.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.Member", b =>
                {
                    b.HasOne("LibraryManager.Domain.Models.User", "User")
                        .WithOne("Member")
                        .HasForeignKey("LibraryManager.Domain.Models.Member", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.State", b =>
                {
                    b.HasOne("LibraryManager.Domain.Models.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.User", b =>
                {
                    b.HasOne("LibraryManager.Domain.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("LibraryManager.Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("LibraryManager.Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryManager.Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("LibraryManager.Domain.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.Book", b =>
                {
                    b.Navigation("BookItems");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.BookItem", b =>
                {
                    b.Navigation("BookLending");

                    b.Navigation("BookReservation");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.City", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.Country", b =>
                {
                    b.Navigation("States");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.Library", b =>
                {
                    b.Navigation("BookItems");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.Member", b =>
                {
                    b.Navigation("CheckedOutBooks");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.State", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("LibraryManager.Domain.Models.User", b =>
                {
                    b.Navigation("Librarian");

                    b.Navigation("Member");
                });
#pragma warning restore 612, 618
        }
    }
}

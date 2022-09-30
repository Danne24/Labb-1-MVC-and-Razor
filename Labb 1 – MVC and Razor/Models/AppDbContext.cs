using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb_1___MVC_and_Razor.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<LibraryLoan> LibraryLoans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 1,
                BookTitle = "Dune",
                BookAuthor = "Frank Herbert",
                BookPublishedYear = "1965",
                BookCurrentlyAvailableForRent = true,
                BookImageThmbnailUrl = "\\images\\Dune.webp",
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 2,
                BookTitle = "Jurassic Park",
                BookAuthor = "Michael Crichton",
                BookPublishedYear = "1990",
                BookCurrentlyAvailableForRent = true,
                BookImageThmbnailUrl = "\\images\\Jurassic Park.webp",
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 3,
                BookTitle = "Treasure Island",
                BookAuthor = "Robert Louis Stevenson",
                BookPublishedYear = "1883",
                BookCurrentlyAvailableForRent = true,
                BookImageThmbnailUrl = "\\images\\Treasure Island.jpg",
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 4,
                BookTitle = "Twenty Thousand Leagues Under the Sea",
                BookAuthor = "Jules Verne",
                BookPublishedYear = "1870",
                BookCurrentlyAvailableForRent = true,
                BookImageThmbnailUrl = "\\images\\Twenty Thousand Leagues Under the Sea.jpg",
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 5,
                BookTitle = "Frankenstein",
                BookAuthor = "Mary Shelley",
                BookPublishedYear = "1818",
                BookCurrentlyAvailableForRent = true,
                BookImageThmbnailUrl = "\\images\\Frankenstein.jpg",
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                BookID = 6,
                BookTitle = "War and Peace",
                BookAuthor = "Leo Tolstoy",
                BookPublishedYear = "1869",
                BookCurrentlyAvailableForRent = true,
                BookImageThmbnailUrl = "\\images\\War and peace.jpg",
            });





            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerID = 1,
                CustomerFirstName = "Daniel",
                CustomerLastName = "Gyrén",
                CustomerAge = 25,
                CustomerGender = "Male",
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerID = 2,
                CustomerFirstName = "Paul",
                CustomerLastName = "Foster",
                CustomerAge = 55,
                CustomerGender = "Male",
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerID = 3,
                CustomerFirstName = "Gareth",
                CustomerLastName = "Archer",
                CustomerAge = 31,
                CustomerGender = "Male",
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerID = 4,
                CustomerFirstName = "Jordan",
                CustomerLastName = "Humble",
                CustomerAge = 20,
                CustomerGender = "Male",
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerID = 5,
                CustomerFirstName = "James",
                CustomerLastName = "Johnson",
                CustomerAge = 35,
                CustomerGender = "Male",
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerID = 6,
                CustomerFirstName = "Janet",
                CustomerLastName = "Johnson",
                CustomerAge = 35,
                CustomerGender = "Female",
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerID = 7,
                CustomerFirstName = "Morgan",
                CustomerLastName = "Karlsson",
                CustomerAge = 41,
                CustomerGender = "Male",
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerID = 8,
                CustomerFirstName = "Ola-Conny",
                CustomerLastName = "Wallgren",
                CustomerAge = 52,
                CustomerGender = "Male",
            });




            modelBuilder.Entity<LibraryLoan>().HasData(new LibraryLoan
            {
                LibraryLoanID = 1,
                BookID = 1,
                CustomerID = 1,
                DateOfLoan = DateTime.Now,
                LastDateToReturn = DateTime.Now.AddDays(45),
                IsReturned = false,
            });
            modelBuilder.Entity<LibraryLoan>().HasData(new LibraryLoan
            {
                LibraryLoanID = 2,
                BookID = 2,
                CustomerID = 1,
                DateOfLoan = DateTime.Now,
                LastDateToReturn = DateTime.Now.AddDays(45),
                IsReturned = true,
            });
            modelBuilder.Entity<LibraryLoan>().HasData(new LibraryLoan
            {
                LibraryLoanID = 3,
                BookID = 3,
                CustomerID = 1,
                DateOfLoan = DateTime.Now,
                LastDateToReturn = DateTime.Now.AddDays(45),
                IsReturned = false,
            });
            modelBuilder.Entity<LibraryLoan>().HasData(new LibraryLoan
            {
                LibraryLoanID = 4,
                BookID = 4,
                CustomerID = 2,
                DateOfLoan = DateTime.Now,
                LastDateToReturn = DateTime.Now.AddDays(45),
                IsReturned = false,
            });
            modelBuilder.Entity<LibraryLoan>().HasData(new LibraryLoan
            {
                LibraryLoanID = 5,
                BookID = 5,
                CustomerID = 2,
                DateOfLoan = DateTime.Now,
                LastDateToReturn = DateTime.Now.AddDays(45),
                IsReturned = true,
            });
            modelBuilder.Entity<LibraryLoan>().HasData(new LibraryLoan
            {
                LibraryLoanID = 6,
                BookID = 6,
                CustomerID = 2,
                DateOfLoan = DateTime.Now,
                LastDateToReturn = DateTime.Now.AddDays(45),
                IsReturned = true,
            });
        }
    }
}

using System;
using BookCatalogs.Models;
using Microsoft.EntityFrameworkCore;

namespace BookCatalogs.helper
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }
    }
}

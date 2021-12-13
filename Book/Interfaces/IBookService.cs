using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BookCatalogs.Dtos;
using BookCatalogs.Models;

namespace BookCatalogs.Interfaces
{
    public interface IBookService
    {

        public Task<IEnumerable<Book>> getAllBooks();

        public Task<Book> getBookByID(Guid id);

        public Task<Guid> createBook(BookDto book);

        public Task updateBook(Guid id, BookDto book);

        public Task deleteBook(Guid id);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using BookCatalogs.Dtos;
using BookCatalogs.helper;
using BookCatalogs.Models;
using BookCatalogs.Interfaces;
using BookCatalogs.Exceptions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookCatalogs.Services
{
    public class BookSerice : IBookService
    {
        private List<Models.Book> _bookList;
        private BookContext _context;

        public BookSerice(BookContext db)
        {
            _context = db;


            //foreach (var item in _context.Books) {
            //    _bookList.Add(item);
            //}

            //if (_bookList != null && _bookList.Count > 0) {
            //    _context.Books.Add(new Book { id = Guid.NewGuid(), Title = "Biblia", Price = 200 });
            //    _context.Books.Add(new Book { id = Guid.NewGuid(), Title = "Game of Trone", Price = 200 });

            //    _bookList = new List<Book> {
            //    new Book { id = Guid.NewGuid(), Title = "Biblia", Price = 200 },
            //    new Book { id = Guid.NewGuid(), Title = "Game of Trone", Price = 200 }
            //    };
            //}
        }

        public async Task<Guid> createBook(BookDto book)
        {
            var entity = new Book(){ Price = book.Price, Title = book.Title };

            await _context.Books.AddAsync(entity);

            await _context.SaveChangesAsync();

            return entity.id;
        }

        public async Task deleteBook(Guid id)
        {
            var entity = await _context.Books.FindAsync(id);

            if (entity == null)
                throw new NotFoundException($"Libro con el id: {id} no encontrado");

            _context.Books.Remove(entity);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Book>> getAllBooks()
        {
            return await _context.Books.ToListAsync();
        }

        public async Task<Book> getBookByID(Guid id)
        {
            var book = await _context.Books.FindAsync(id);
            return book;
        }

        public async Task updateBook(Guid id, BookDto book)
        {
            var entity = await _context.Books.FindAsync(id);

            if (entity == null)
                throw new NotFoundException($"Libro con el id: {id} no encontrado");

            entity.Title = book.Title;
            entity.Price = book.Price;

            await _context.SaveChangesAsync();
            
        }
    }
}

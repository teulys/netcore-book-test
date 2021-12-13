using System;
using System.Collections.Generic;
using System.Linq;
using BookCatalogs.Dtos;
using BookCatalogs.Models;

namespace BookCatalogs.Interfaces
{
    //public class InMemoryBook: IBookService
    //{

    //    private List<Book> _bookList;

    //    public InMemoryBook()
    //    {
    //        _bookList = new List<Book> {
    //            new Book { id = Guid.NewGuid(), Title = "Biblia", Price = 200 },
    //            new Book { id = Guid.NewGuid(), Title = "Game of Trone", Price = 200 }
    //        };
    //    }

    //    public void createBook(BookDto book)
    //    {
    //        _bookList.Add(book);
    //    }

    //    public void deleteBook(Guid id)
    //    {
    //        var book = _bookList.Where(x => x.id == id).FirstOrDefault();

    //        if (book != null) {
    //            _bookList.Remove(book);
    //        }
    //    }

    //    public IEnumerable<Book> getAllBooks()
    //    {
    //        return _bookList;
    //    }

    //    public Book getBookByID(Guid id)
    //    {
    //        var book = _bookList.Where(x => x.id == id).FirstOrDefault();
    //        return book;
    //    }

    //    public void updateBook(Guid id, Book book)
    //    {
    //        var b = _bookList.FindIndex(x => x.id == id);
    //        if (b > 0) {
    //            _bookList[b] = book;
    //        }
    //    }
    //}
}

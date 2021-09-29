using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Bookish.Database;
using Bookish.Models;
using System.Linq;

namespace Bookish.Services
{
    public interface IBookService
    {
        public List<BookModel> getAllBooks();
        public BookModel getBook(int bookId);
    }
    public class BookService : IBookService
    {
        private readonly LibraryContext _libraryContext;

        public BookService(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }

        public List<BookModel> getAllBooks()
        {
            List<BookModel> books = _libraryContext.Books.ToList();
            return books;
        }

        public BookModel getBook(int bookId)
        {
            BookModel book = _libraryContext.Books.Where(b => b.Id == bookId).Single();
            return book;
        }
    }

}
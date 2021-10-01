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
        public List<BookCopyModel> getAllCopies();
        public void AddBookToDb(BookModel book);
        public void RemoveBookFromDb(int id);
        public void AddBookCopy(int id);
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
            List<BookModel> books = _libraryContext.Book.Include(b => b.Author).ToList();
            return books;
        }

        public BookModel getBook(int bookId)
        {
            BookModel book = _libraryContext.Book.Where(b => b.Id == bookId).Include(b => b.Author).Single();
            return book;
        }

        public List<BookCopyModel> getAllCopies()
        {
            List<BookCopyModel> copies = _libraryContext.BookCopy.ToList();
            return copies;
        }

        public void AddBookToDb(BookModel book)
        {
            _libraryContext.Book.Add(book);
            _libraryContext.SaveChanges();
        }

        public void RemoveBookFromDb(int id)
        {
            BookModel book = _libraryContext.Book.Where(b => b.Id == id).Single();
            _libraryContext.Book.Remove(book);
            _libraryContext.SaveChanges();
        }

        public void AddBookCopy(int id)
        {
            BookCopyModel bookCopy = new BookCopyModel
            {
                BookId = id
            };
            _libraryContext.BookCopy.Add(bookCopy);
            _libraryContext.SaveChanges();
        }

// public int getBookCopyCount(int id)
//         {
//             var bookCopyCount = _libraryContext.Book.Where(b => b.Id == id)
//                         .Include(s => s.Grade)
//                             .ThenInclude(g => g.Teachers)
//                         .FirstOrDefault();
//         }

        

    }

}
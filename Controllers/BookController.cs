using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookish.Models;
using Bookish.Services;

namespace Bookish.Controllers
{
    [Route("books")]
    public class BookController : Controller
    {

        private readonly IBookService _bookService;
        private readonly IAuthorService _authorService;

        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger, IBookService bookService, IAuthorService authorService)
        {
            _logger = logger;
            _bookService = bookService;
            _authorService = authorService;
        }

        
        public IActionResult AllBooksView()
        {
            return View(_bookService.getAllBooks());

        }
        [HttpGet("{id}")]
        public IActionResult BookView(int id)
        {
            return View(_bookService.getBook(id));

        }
        [HttpGet("Delete")]
         public IActionResult DeleteBook(int id)
        {
            _bookService.RemoveBookFromDb(id);
            return RedirectToAction("AllBooksView");

        }
    
        [HttpPost("book")]
        public IActionResult AddBookCopy(int id)
        {
            _bookService.AddBookCopy(id);
            return RedirectToAction("BookView","Book",new {id=id});

        }
         [HttpGet("create")]
        public IActionResult AddBookView()
        {
            ViewBag.authors = _authorService.getAllAuthors();
            return View();
        }

         [HttpPost("create")]
        public IActionResult AddBook(BookModel book)
        {
            _bookService.AddBookToDb(book);
            TempData["Success"] = "Book Added Successfully!";
            return RedirectToAction("AddBookView");
        }
        [HttpGet("copies")]
        public IActionResult IndView()
        {
            return View(_bookService.getAllCopies());
        }
    }
}

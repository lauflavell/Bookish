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
    [Route("Books")]
    public class BookController : Controller
    {

        private readonly IBookService _bookService;

        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            return View(_bookService.getAllBooks());

        }
        [HttpGet("Book")]
        public IActionResult BookView(int id)
        {
            return View(_bookService.getBook(id));

        }
     


    }
}

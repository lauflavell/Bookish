using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bookish.Models;
namespace Bookish.Controllers
{
    [Route("Books")]
    public class BookController : Controller
    {

        static List<BookModel> BookList = new List<BookModel> 
        {
            
        };
        private readonly ILogger<BookController> _logger;

        public BookController(ILogger<BookController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(
                new List<BookModel> 
                {
                    new BookModel("Harry Potter and The Philospher's Stone", "J.K Rowling"),
                    new BookModel("Harry Potter and The Chamber of Secrets", "J.K Rowling"),
                    new BookModel("Harry Potter and The Prisoner of Azkaban", "J.K Rowling"),
                    new BookModel("Harry Potter and The Order of the Phoneix", "J.K Rowling"),
                    new BookModel("Harry Potter and The Half Blood Prince",  "J.K Rowling"),
                    new BookModel("Harry Potter and The Deathly Hallows", "J.K Rowling")
                }
            );
        }
    

    }
}

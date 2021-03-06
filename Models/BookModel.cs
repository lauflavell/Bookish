using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Bookish.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public AuthorModel Author { get; set; }
        public int AuthorId { get; set; }
        public string ISBN { get; set; }
        public DateTime DatePublished { get; set; }
        public string Publisher { get; set; }
        public string Format { get; set; }
        public string Genre { get; set; }
    
    }
}

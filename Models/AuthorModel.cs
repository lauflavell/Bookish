using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Bookish.Models
{
    public class AuthorModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookModel> Books { get; set;}        
    }      
}

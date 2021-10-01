using System;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Models
{
    public class BookCopyModel
    {
        public int Id { get; set; }
        public int BookId { get; set; } 
    }
     
}

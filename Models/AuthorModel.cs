using System;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Models
{
    public class AuthorModel
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }      
}

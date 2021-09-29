using System;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Models
{
    public class IndividualBookModel
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string Status { get; set; }
    }
        enum Status
        {
            Available,
            Onloan,
            Overdue
        }
     
}

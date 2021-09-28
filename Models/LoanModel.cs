using System;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Models
{
    public class LoanModel
    {
        public int LoanId { get; set; }
        public DateTime DateLoaned { get; set; }
        public int IndividualBookId { get; set; }
        public int MemberId { get; set; }
        public DateTime DateReturned { get; set; }

        public DateTime DueDate { get; set; }
    }      
}

using System;
using Microsoft.EntityFrameworkCore;

namespace Bookish.Models
{
    public class MemberModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
    }   
}

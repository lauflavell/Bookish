using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Bookish.Models;

namespace Bookish.Database
{
    public class LibraryContext : DbContext
    {
        public DbSet<BookModel> Books { get; set; }
        public DbSet<IndividualBookModel> Book { get; set; }
        public DbSet<AuthorModel> Authors { get; set; }
        public DbSet<MemberModel> Members { get; set; }
        public DbSet<LoanModel> Loans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=BookishDatabase;Trusted_Connection=True;");
        }

    }

}

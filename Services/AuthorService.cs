using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Bookish.Database;
using Bookish.Models;
using System.Linq;


namespace Bookish.Services
{
    public interface IAuthorService
    {
        public List<AuthorModel> getAllAuthors();

    }
    public class AuthorService : IAuthorService
    {
        private readonly LibraryContext _libraryContext;

        public AuthorService(LibraryContext libraryContext)
        {
            _libraryContext = libraryContext;
        }
        public List<AuthorModel> getAllAuthors()
        {
            List<AuthorModel> authors = _libraryContext.Author.ToList();
            return authors;
        }
    }

}

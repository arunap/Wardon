using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Wardon.Contracts.Repositories;
using Wardon.Domain.Entities;

namespace Wardon.Services.Repositories
{ 
    public class BookRepository : IBookRepository
    {
        public bool DeleteBookAsync(Book book)
        {
            throw new NotImplementedException();
        }

        public Book GetBookAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Book GetBookIncludeAuthorsAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooksAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooksIncludeAuthorsAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public bool InsertBookAsync(Book book)
        {
            throw new NotImplementedException();
        }

        public bool UpdateBookAsync(Book book)
        {
            throw new NotImplementedException();
        }
    }
}

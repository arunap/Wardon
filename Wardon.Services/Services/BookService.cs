using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Wardon.Contracts;
using Wardon.Contracts.Repositories;
using Wardon.Domain.ViewModels;

namespace Wardon.Services.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Task<bool> DeleteBookAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<BookViewModel> GetBookAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<BookViewModel> GetBookIncludeAuthorsAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<BookViewModel>> GetBooksAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<BookViewModel>> GetBooksIncludeAuthorsAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> InsertBookAsync(BookViewModel book)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateBookAsync(BookViewModel book)
        {
            throw new NotImplementedException();
        }
    }
}

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Wardon.Domain.Entities;

namespace Wardon.Contracts.Repositories
{
    public interface IBookRepository
    {
        Task<Book> GetBookAsync(int id, CancellationToken cancellationToken);
        Task<Book> GetBookIncludeAuthorsAsync(int id, CancellationToken cancellationToken);
        Task<List<Book>> GetBooksAsync(CancellationToken cancellationToken);
        Task<List<Book>> GetBooksIncludeAuthorsAsync(CancellationToken cancellationToken);
        Task<bool> UpdateBookAsync(Book book);
        Task<bool> InsertBookAsync(Book book);
        Task<bool> DeleteBookAsync(Book book);
    }
}

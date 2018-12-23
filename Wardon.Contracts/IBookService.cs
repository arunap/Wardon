using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Wardon.Domain.ViewModels;

namespace Wardon.Contracts
{
    public interface IBookService
    {
        Task<BookViewModel> GetBookAsync(int id, CancellationToken cancellationToken);
        Task<BookViewModel> GetBookIncludeAuthorsAsync(int id, CancellationToken cancellationToken);
        Task<List<BookViewModel>> GetBooksAsync(CancellationToken cancellationToken);
        Task<List<BookViewModel>> GetBooksIncludeAuthorsAsync(CancellationToken cancellationToken);
        Task<bool> InsertBookAsync(BookViewModel book);
        Task<bool> UpdateBookAsync(BookViewModel book);
        Task<bool> DeleteBookAsync(int id);
    }
}

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Wardon.Domain.ViewModels;

namespace Wardon.Contracts
{
    public interface IAuthorService
    {
        Task<bool> DeleteAuthorAsync(AuthorViewModel author);
        Task<AuthorViewModel> GetAuthorAsync(int id, CancellationToken cancellationToken);
        Task<AuthorViewModel> GetAuthorIncludeAuthorsAsync(int id, CancellationToken cancellationToken);
        Task<List<AuthorViewModel>> GetAuthorsAsync(CancellationToken cancellationToken);
        Task<List<AuthorViewModel>> GetAuthorsIncludeAuthorsAsync(CancellationToken cancellationToken);
        Task<bool> InsertAuthorAsync(AuthorViewModel author);
        Task<bool> UpdateAuthorAsync(AuthorViewModel author);
    }
}

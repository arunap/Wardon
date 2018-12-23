using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Wardon.Domain.Entities;

namespace Wardon.Contracts.Repositories
{
    public interface IAuthorRepository
    {
        Task<Author> GetAuthorAsync(int id, CancellationToken cancellationToken);
        Task<Author> GetAuthorIncludeAuthorsAsync(int id, CancellationToken cancellationToken);
        Task<List<Author>> GetAuthorsAsync(CancellationToken cancellationToken);
        Task<List<Author>> GetAuthorsIncludeAuthorsAsync(CancellationToken cancellationToken);
        Task<bool> UpdateAuthorAsync(Author author);
        Task<bool> InsertAuthorAsync(Author author);
        Task<bool> DeleteAuthorAsync(Author author);
    }
}

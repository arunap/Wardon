using System;
using System.Collections.Generic;
using System.Threading;
using Wardon.Contracts.Repositories;
using Wardon.Domain.Entities;

namespace Wardon.Services.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        public bool DeleteAuthorAsync(Author author)
        {
            throw new NotImplementedException();
        }

        public Author GetAuthorAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Author GetAuthorIncludeAuthorsAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public List<Author> GetAuthorsAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public List<Author> GetAuthorsIncludeAuthorsAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public bool InsertAuthorAsync(Author author)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAuthorAsync(Author author)
        {
            throw new NotImplementedException();
        }
    }
}

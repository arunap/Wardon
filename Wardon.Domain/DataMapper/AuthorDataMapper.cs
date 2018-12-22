using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wardon.Domain.Entities;
using Wardon.Domain.ViewModels;

namespace Wardon.Domain.DataMapper
{
    public class AuthorDataMapper : IDataMapper<Entities.Author, ViewModels.AuthorViewModel>
    {
        public AuthorViewModel Map(Author entry)
        {
            return new AuthorViewModel
            {
                AuthorId = entry.AuthorId,
                FirstName = entry.FirstName,
                LastName = entry.LastName,
                FullName = $"{entry.FirstName} {entry.LastName}",
            };
        }

        public List<AuthorViewModel> Map(List<Author> entries)
        {
            return entries.Select(entry => new AuthorViewModel
            {
                AuthorId = entry.AuthorId,
                FirstName = entry.FirstName,
                LastName = entry.LastName,
                FullName = $"{entry.FirstName} {entry.LastName}",
                Books = entry?.Books?.Select(x => new BookViewModel
                {
                    BookId = x.BookId,
                    ISBN = x.ISBN,
                    Publisher = x.Publisher,
                    Title = x.Title,
                    PublishedOnUtc = x.PublishedOnUtc,
                }).ToList()
            }).ToList();
        }
    }
}

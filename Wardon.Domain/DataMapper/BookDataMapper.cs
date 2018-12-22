using System.Collections.Generic;
using System.Linq;
using Wardon.Domain.Entities;
using Wardon.Domain.ViewModels;

namespace Wardon.Domain.DataMapper
{
    public class BookDataMapper : IDataMapper<Entities.Book, ViewModels.BookViewModel>
    {
        public BookViewModel Map(Book entry)
        {
            return new BookViewModel
            {
                BookId = entry.BookId,
                ISBN = entry.ISBN,
                Publisher = entry.Publisher,
                Title = entry.Title,
                PublishedOnUtc = entry.PublishedOnUtc,
                Authors = entry.Authors.Select(x => new AuthorViewModel
                {
                    AuthorId = x.AuthorId,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    FullName = $"{x.FirstName} {x.LastName}",
                }).ToList()
            };
        }

        public List<BookViewModel> Map(List<Book> entries)
        {
            return entries.Select(x => new BookViewModel
            {
                BookId = x.BookId,
                ISBN = x.ISBN,
                Publisher = x.Publisher,
                Title = x.Title,
                PublishedOnUtc = x.PublishedOnUtc,
                Authors = x?.Authors?.Select(y => new AuthorViewModel
                {
                    AuthorId = y.AuthorId,
                    FirstName = y.FirstName,
                    LastName = y.LastName,
                    FullName = $"{y.FirstName} {y.LastName}",
                }).ToList()
            }).ToList();
        }
    }
}

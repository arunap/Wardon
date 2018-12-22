using System;
using System.Collections.Generic;
using System.Text;

namespace Wardon.Domain.ViewModels
{
    public class BookViewModel
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Publisher { get; set; }
        public string PublishedOnUtc { get; set; }
        public List<AuthorViewModel> Authors { get; set; } 
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Wardon.Domain.ViewModels
{
    public class AuthorViewModel
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public List<BookViewModel> Books { get; set; }
        public string FullName { get; set; }
    }
}

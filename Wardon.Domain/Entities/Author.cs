using System.Collections.Generic;

namespace Wardon.Domain.Entities
{
    public class Author : BaseEntity
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}

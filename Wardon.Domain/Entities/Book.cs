using System.Collections.Generic;

namespace Wardon.Domain.Entities
{
    public class Book : BaseEntity
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Publisher { get; set; }
        public string PublishedOnUtc { get; set; }
        public ICollection<Author> Authors { get; set; } = new HashSet<Author>();
    }
}

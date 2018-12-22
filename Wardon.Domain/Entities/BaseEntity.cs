using System;
using System.ComponentModel.DataAnnotations;

namespace Wardon.Domain.Entities
{
    public class BaseEntity
    {
        public int CreatedBy { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public int LastUpdatedBy { get; set; }
        public DateTime LastUpdatedOnUtc { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}

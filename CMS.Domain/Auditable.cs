using System;

namespace CMS.Domain
{
    public class Auditable : EntityWithStatus
    {
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public DateTime DeletedAt { get; set; }

        public string DeletedBy { get; set; }

        public string CreatedBy { get; set; }

        public void Create(string createdBy)
        {
            CreatedBy = createdBy;
            CreatedAt = DateTime.UtcNow;
        }
    }
}

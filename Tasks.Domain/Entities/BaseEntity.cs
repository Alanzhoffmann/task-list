using System;
using Tasks.Domain.Interfaces.Entities;

namespace Tasks.Domain.Entities
{
    public class BaseEntity : IBaseEntity
    {
        public BaseEntity()
        {
            Created = DateTime.Now;
        }

        public long Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime Created { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}

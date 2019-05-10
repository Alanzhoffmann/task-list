using System;

namespace Tasks.Domain.Interfaces.Entities
{
    public interface IBaseEntity
    {
        long Id { get; set; }
        bool IsDeleted { get; set; }
        DateTime Created { get; set; }
        DateTime? LastUpdated { get; set; }
    }
}

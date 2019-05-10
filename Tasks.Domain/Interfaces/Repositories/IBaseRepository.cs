using Tasks.Domain.Interfaces.Entities;

namespace Tasks.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : IBaseEntity, new()
    {
    }
}

using Tasks.Domain.Interfaces.Entities;

namespace Tasks.Domain.Interfaces.Services
{
    public interface IBaseService<T> where T : IBaseEntity, new()
    {
    }
}

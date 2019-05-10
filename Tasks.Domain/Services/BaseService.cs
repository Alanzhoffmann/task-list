using Tasks.Domain.Interfaces.Entities;
using Tasks.Domain.Interfaces.Repositories;
using Tasks.Domain.Interfaces.Services;

namespace Tasks.Domain.Services
{
    public abstract class BaseService<T> : IBaseService<T> where T : IBaseEntity, new()
    {
        private readonly IBaseRepository<T> _repository;

        public BaseService(IBaseRepository<T> repository)
        {
            _repository = repository;
        }
    }
}

using LabNetBank.Business.Models;

namespace LabNetBank.Business.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task<TEntity> Create(TEntity entity);
        Task<List<TEntity>> GetAll();
        Task<int> SaveChanges();
    }
}

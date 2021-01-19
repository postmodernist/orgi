using System.Collections.Generic;
using System.Threading.Tasks;
using DecadenceV3DAL.Entities;

namespace DecadenceV3DAL.Repositories
{
    public interface IGenericRepository<TEntity> where  TEntity: Entity
    {
        Task Add(TEntity entity);
        Task<TEntity> GetEntityById(int id);
        Task<IEnumerable<TEntity>> GetEntities();
        Task Update(TEntity entity);
        Task Delete(TEntity entity);
    }
}
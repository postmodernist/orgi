using System.Collections.Generic;
using DecadenceV3DAL.Entities;

namespace DecadenceV3DAL.Repositories
{
    public interface IGenericRepository<TEntity> where  TEntity: Entity
    {
        void Add(TEntity entity);
        TEntity GetEntityById(int id);
        IEnumerable<TEntity> GetEntities();
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
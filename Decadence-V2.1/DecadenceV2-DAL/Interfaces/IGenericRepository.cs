using System.Collections.Generic;

namespace DecadenceV2_1_DAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class, new()
    {
        void Add(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
using System;
using System.Collections.Generic;


namespace Decadence_DAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : IEntity
    {
        int Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
    }
}

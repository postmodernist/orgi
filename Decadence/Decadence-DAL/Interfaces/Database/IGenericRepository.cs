using System;
using System.Collections.Generic;
using System.Text;


namespace Decadence_DAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity: IEntity
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(Guid id);
        Guid Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}

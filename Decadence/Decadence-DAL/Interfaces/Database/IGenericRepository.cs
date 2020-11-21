using System;
using System.Collections.Generic;
using System.Text;


namespace Decadence_DAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity: IEntity
    {
        Guid Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity Get(Guid id);
        IEnumerable<TEntity> GetAll();
    }
}

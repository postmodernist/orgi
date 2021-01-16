using System.Collections.Generic;
using System.Linq;
using DecadenceV3DAL.Entities;
using DecadenceV3DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace DecadenceV3DAL.Repositories
{
    public class GenericRepository<TEntity>: IGenericRepository<TEntity> where TEntity: Entity
    {
        private AppDbContext _context;
        private DbSet<TEntity> _entities;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _entities = _context.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _entities.Add(entity);
            _context.SaveChanges();
        }

        public TEntity GetEntityById(int id)
        {
            return _entities.Find(id);
        }

        public IEnumerable<TEntity> GetEntities()
        {
            return _entities.AsNoTracking().ToList();
        }

        public void Update(TEntity entity)
        {
            _entities.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _entities.Remove(entity);
            _context.SaveChanges();
        }
    }
}
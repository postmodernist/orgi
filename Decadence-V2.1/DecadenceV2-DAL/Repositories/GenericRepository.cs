using System.Collections.Generic;
using System.Linq;
using DecadenceV2_1_DAL.Interfaces;
using DecadenceV2_1_DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace DecadenceV2_1_DAL.Repositories
{
    public class GenericRepository<TEntity> :IGenericRepository<TEntity> where TEntity: class ,new()
    {
        private AppDataContext _context;
        private DbSet<TEntity> _entities;

        public GenericRepository(AppDataContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _entities.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _entities.AsNoTracking().ToList();
        }

        public TEntity GetById(int id)
        {
            return _entities.Find(id);
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
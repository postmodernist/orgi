using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task Add(TEntity entity)
        {
            await _entities.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<TEntity> GetEntityById(int id)
        {
            return await _entities.FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetEntities()
        {
            return await _entities.AsNoTracking().ToListAsync();
        }

        public async Task Update(TEntity entity)
        {
            _entities.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(TEntity entity)
        {
            _entities.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
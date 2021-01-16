using DecadenceV3DAL.Entities;
using DecadenceV3DAL.Repositories.EntitiesRepos;
using DecadenceV3DAL.UnitOfWork;

namespace DecadenceV3DAL.Repositories.Entities
{
    public class FilterRepository:GenericRepository<Filter>, IFilterRepository
    {
        public FilterRepository(AppDbContext context):base(context)
        {
        }
    }
}
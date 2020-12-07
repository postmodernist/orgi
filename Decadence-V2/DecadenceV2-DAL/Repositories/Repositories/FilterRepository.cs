using DecadenceV2_DAL.Entities;
using DecadenceV2_DAL.Interfaces.IRepositories;
using DecadenceV2_DAL.UnitOfWork;

namespace DecadenceV2_DAL.Repositories.Repositories
{
    public class FilterRepository:GenericRepository<Filter>, IFilterRepository
    {
        public FilterRepository(AppDataContext context):base(context)
        {
        }
    }
}
using DecadenceV3DAL.Entities;
using DecadenceV3DAL.Repositories.EntitiesRepos;
using DecadenceV3DAL.UnitOfWork;

namespace DecadenceV3DAL.Repositories.Entities
{
    public class WorkItemRepository: GenericRepository<WorkItem>, IWorkItemRepository
    {
        public WorkItemRepository(AppDbContext context): base(context)
        {
            
        }
    }
}
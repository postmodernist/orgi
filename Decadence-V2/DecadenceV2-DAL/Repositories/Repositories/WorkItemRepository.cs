using DecadenceV2_DAL.Entities;
using DecadenceV2_DAL.Interfaces.IRepositories;
using DecadenceV2_DAL.UnitOfWork;

namespace DecadenceV2_DAL.Repositories.Repositories
{
    public class WorkItemRepository:GenericRepository<WorkItem>, IWorkItemRepository
    {
        public WorkItemRepository(AppDataContext context):base(context)
        {
            
        }
    }
}
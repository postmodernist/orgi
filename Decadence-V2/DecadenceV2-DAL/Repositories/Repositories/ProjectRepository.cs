using DecadenceV2_DAL.Entities;
using DecadenceV2_DAL.Interfaces.IRepositories;
using DecadenceV2_DAL.UnitOfWork;

namespace DecadenceV2_DAL.Repositories.Repositories
{
    public class ProjectRepository:GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(AppDataContext context):base(context)
        {
            
        }
    }
}
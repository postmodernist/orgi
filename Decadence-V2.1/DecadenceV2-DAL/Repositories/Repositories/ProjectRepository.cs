using DecadenceV2_1_DAL.Entities;
using DecadenceV2_1_DAL.Interfaces.IRepositories;
using DecadenceV2_1_DAL.UnitOfWork;

namespace DecadenceV2_1_DAL.Repositories.Repositories
{
    public class ProjectRepository:GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(AppDataContext context):base(context)
        {
            
        }
    }
}
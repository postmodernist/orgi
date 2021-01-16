using DecadenceV3DAL.Entities;
using DecadenceV3DAL.Repositories.EntitiesRepos;
using DecadenceV3DAL.UnitOfWork;

namespace DecadenceV3DAL.Repositories.Entities
{
    public class ProjectRepository: GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(AppDbContext context): base(context)
        {
        }
    }
}
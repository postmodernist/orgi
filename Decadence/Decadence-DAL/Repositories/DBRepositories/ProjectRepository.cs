using Decadence_DAL.Entities;
using Decadence_DAL.Interfaces;


namespace Decadence_DAL.Repositories
{
    public class ProjectRepository: GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(IConnectionFactory connectionFactory) : base(connectionFactory, "PROJECTS", false)
        {
        }
    }
}
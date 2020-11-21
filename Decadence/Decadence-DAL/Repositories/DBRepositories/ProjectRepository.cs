using Decadence_DAL.Entities;
using Decadence_DAL.Interfaces;
using Decadence_DAL.Interfaces.Database.IRepositories;

namespace Decadence_DAL.Repositories.DBRepositories
{
    public class ProjectRepository: GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(IConnectionFactory connectionFactory) : base(connectionFactory, "PROJECTS", false)
        {
        }
    }
}
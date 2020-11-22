using Decadence_DAL.Entities;
using Decadence_DAL.Interfaces;


namespace Decadence_DAL.Repositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(IConnectionFactory connectionFactory) : base(connectionFactory, "PROJECTS", false)
        {
            connectionFactory.SetConnection("Server=192.168.56.101;Database=Decadence;User ID=sa;Password=bravoSIX_RED");
        }
    }
}
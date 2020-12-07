using Decadence_DAL.Entities;
using Decadence_DAL.Interfaces;


namespace Decadence_DAL.Repositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        public ProjectRepository(IConnectionFactory connectionFactory) : base(connectionFactory, "PROJECTS", false)
        {
            connectionFactory.SetConnection("Data Source=34.65.147.0;Initial Catalog=FortBoyar;Persist Security Info=True;User ID=SA;Password=bravoSIX_RED");
        }
    }
}
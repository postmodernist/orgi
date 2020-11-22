using System.Configuration;
using Decadence_DAL.Entities;
using Decadence_DAL.Interfaces;

namespace Decadence_DAL.Repositories
{
    public class WorkItemRepository: GenericRepository<WorkItem>, IWorkItemRepository
    {
        public WorkItemRepository(IConnectionFactory connectionFactory) : base(connectionFactory, "WORKITEMS", false)
        {
            connectionFactory.SetConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }
    }
}
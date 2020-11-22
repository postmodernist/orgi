using Decadence_DAL.Entities;
using Decadence_DAL.Interfaces;
using System.Configuration;

namespace Decadence_DAL.Repositories
{
    public class FilterRepository : GenericRepository<Filter>, IFilterRepository
    {
        public FilterRepository(IConnectionFactory connectionFactory) : base(connectionFactory, "Filters", false)
        {
            connectionFactory.SetConnection("Server=192.168.56.101;Database=Decadence;User ID=sa;Password=bravoSIX_RED");
        }
    }
}
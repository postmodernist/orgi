using System.Configuration;
using Decadence_DAL.Entities;
using Decadence_DAL.Interfaces;

namespace Decadence_DAL.Repositories.DBRepositories
{
    public class FilterRepository: GenericRepository<Filter> , IFilterRepository
    {
        public FilterRepository(IConnectionFactory connectionFactory):base(connectionFactory, "USERS",false)
        {
            connectionFactory.SetConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }
    }
}
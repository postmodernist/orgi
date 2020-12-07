using Decadence_DAL.Entities;
using Decadence_DAL.Interfaces;
using System.Configuration;

namespace Decadence_DAL.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(IConnectionFactory connectionFactory) : base(connectionFactory, "Users", false)
        {
            connectionFactory.SetConnection("Data Source=34.65.147.0;Initial Catalog=FortBoyar;Persist Security Info=True;User ID=SA;Password=bravoSIX_RED");
        }
    }
}
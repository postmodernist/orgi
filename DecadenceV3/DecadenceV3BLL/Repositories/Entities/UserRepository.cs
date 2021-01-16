using DecadenceV3DAL.Entities;
using DecadenceV3DAL.Repositories.EntitiesRepos;
using DecadenceV3DAL.UnitOfWork;

namespace DecadenceV3DAL.Repositories.Entities
{
    public class UserRepository: GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context): base(context)
        {
            
        }
    }
}
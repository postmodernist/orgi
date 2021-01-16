using DecadenceV3DAL.Entities;
using DecadenceV3DAL.Repositories.EntitiesRepos;
using DecadenceV3DAL.UnitOfWork;

namespace DecadenceV3DAL.Repositories.Entities
{
    public class LabelRepository:GenericRepository<Label>, ILabelRepository
    {
        public LabelRepository(AppDbContext context):base(context)
        {
            
        }
    }
}
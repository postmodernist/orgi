using DecadenceV2_DAL.Entities;
using DecadenceV2_DAL.Interfaces.IRepositories;
using DecadenceV2_DAL.UnitOfWork;

namespace DecadenceV2_DAL.Repositories.Repositories
{
    public class LabelRepository:GenericRepository<Label>, ILabelRepository
    {
        public LabelRepository(AppDataContext context):base(context)
        {
            
        }
    }
}
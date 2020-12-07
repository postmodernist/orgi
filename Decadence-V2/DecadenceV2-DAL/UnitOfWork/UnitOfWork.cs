using DecadenceV2_DAL.Interfaces;
using DecadenceV2_DAL.Interfaces.IRepositories;
using DecadenceV2_DAL.Repositories.Repositories;

namespace DecadenceV2_DAL.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly IFilterRepository _FilterRepository;
        private readonly ILabelRepository _LabelRepository;
        private readonly IProjectRepository _ProjectRepository;
        private readonly IUserRepository _UserRepository;
        private readonly IWorkItemRepository _WorkItemRepository;

        public UnitOfWork(AppDataContext context)
        {
            _FilterRepository = new FilterRepository(context);
            _LabelRepository = new LabelRepository(context);
            _ProjectRepository = new ProjectRepository(context);
            _UserRepository = new UserRepository(context);
            _WorkItemRepository = new WorkItemRepository(context);
        }

        public IFilterRepository FilterRepository
        {
            get
            {
                return _FilterRepository;
            }
        }

        public ILabelRepository LabelRepository
        {
            get
            {
                return _LabelRepository;
            }
        }

        public IProjectRepository ProjectRepository
        {
            get
            {
                return _ProjectRepository;
            }
        }

        public IUserRepository UserRepository
        {
            get
            {
                return _UserRepository;
            }
        }

        public IWorkItemRepository WorkItemRepository
        {
            get
            {
                return _WorkItemRepository;
            }
        }
    }
}
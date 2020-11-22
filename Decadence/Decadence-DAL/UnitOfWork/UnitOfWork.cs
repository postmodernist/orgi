using Decadence_DAL.Interfaces;


namespace Decadence_DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IFilterRepository _FilterRepository;
        private readonly ILabelRepository _LabelRepository;
        private readonly IProjectRepository _ProjectRepository;
        private readonly IUserRepository _UserRepository;
        private readonly IWorkItemRepository _WorkItemRepository;

        public UnitOfWork(IFilterRepository filterRepository, ILabelRepository labelRepository,
            IProjectRepository projectRepository, IUserRepository userRepository,
            IWorkItemRepository workItemRepository)
        {
            _FilterRepository = filterRepository;
            _LabelRepository = labelRepository;
            _ProjectRepository = projectRepository;
            _UserRepository = userRepository;
            _WorkItemRepository = workItemRepository;
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
        public void Complete()
        {
            throw new System.NotImplementedException();
        }
    }
}
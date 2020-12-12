using DecadenceV2_1_DAL.Interfaces.IRepositories;

namespace DecadenceV2_1_DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IFilterRepository FilterRepository { get; }
        ILabelRepository LabelRepository { get; }
        IProjectRepository ProjectRepository { get; }
        IUserRepository UserRepository { get; }
        IWorkItemRepository WorkItemRepository { get; }
    }
}
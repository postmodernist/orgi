using DecadenceV3DAL.Repositories.EntitiesRepos;

namespace DecadenceV3DAL.Interfaces
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
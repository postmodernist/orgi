namespace Decadence_DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IFilterRepository FilterRepository { get; }
        ILabelRepository LabelRepository { get; }
        IProjectRepository ProjectRepository { get; }
        IUserRepository UserRepository { get; }
        IWorkItemRepository WorkItemRepository { get; }
        void Complete();
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Decadence_DAL.Interfaces.Database.IRepositories;

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

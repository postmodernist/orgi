using System;
using System.Collections.Generic;
using Decadence_DAL.Entities;

namespace Decadence_DAL.Interfaces
{
    public interface IWorkItemService
    {
        Guid AddWorkItem(WorkItem item);
        void UpdateWorkItem(WorkItem item);
        void DeleteWorkItem(WorkItem item);
        WorkItem GetWorkItemById(Guid id);
        IEnumerable<WorkItem> GetAllWorkItems();
    }
}
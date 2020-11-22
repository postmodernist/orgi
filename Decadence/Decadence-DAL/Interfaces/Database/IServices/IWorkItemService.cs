using Decadence_DAL.Entities;
using System;
using System.Collections.Generic;

namespace Decadence_DAL.Interfaces
{
    public interface IWorkItemService
    {
        int AddWorkItem(WorkItem item);
        void UpdateWorkItem(WorkItem item);
        void DeleteWorkItem(WorkItem item);
        WorkItem GetWorkItemById(int id);
        IEnumerable<WorkItem> GetAllWorkItems();
    }
}
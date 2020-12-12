using System.Collections.Generic;
using DecadenceV2_1_DAL.Entities;

namespace DecadenceV2_1_DAL.Interfaces.IServices
{
    public interface IWorkItemService
    {
        void AddWorkItem(WorkItem item);
        void UpdateWorkItem(WorkItem item);
        void DeleteWorkItem(WorkItem item);
        WorkItem GetWorkItemById(int id);
        IEnumerable<WorkItem> GetAllWorkItems();
    }
}
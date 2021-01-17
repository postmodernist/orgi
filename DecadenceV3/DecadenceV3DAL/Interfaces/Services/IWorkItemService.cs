using System.Collections.Generic;
using DecadenceV3BLL.DTOs;
using DecadenceV3BLL.ViewModels;

namespace DecadenceV3BLL.Interfaces.Services
{
    public interface IWorkItemService
    {
        WorkItemDto GetWokItemById(int id);
        IEnumerable<WorkItemDto> GetWorkItems();
        void AddWorkItem(WorkItemDto workItem);
        void UpdateWorkItem(WorkItemDto workItem);
        void DeleteWorkItem(WorkItemDto workItem);
    }
}
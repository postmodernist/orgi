using System.Collections.Generic;
using System.Threading.Tasks;
using DecadenceV3BLL.DTOs;
using DecadenceV3BLL.ViewModels;

namespace DecadenceV3BLL.Interfaces.Services
{
    public interface IWorkItemService
    {
        Task<WorkItemDto> GetWokItemById(int id);
        Task<IEnumerable<WorkItemDto>> GetWorkItems();
        Task AddWorkItem(WorkItemDto workItem);
        Task UpdateWorkItem(WorkItemDto workItem);
        Task DeleteWorkItem(WorkItemDto workItem);
    }
}
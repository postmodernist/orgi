using System.Collections.Generic;
using DecadenceV3BLL.DTOs;
using DecadenceV3BLL.Interfaces.Services;
using DecadenceV3BLL.ViewModels;
using DecadenceV3DAL.Interfaces;
using DecadenceV3DAL.UnitOfWork;

namespace DecadenceV3BLL.Services
{
    public class WorkItemService: IWorkItemService
    {
        private readonly IUnitOfWork unitOfWork;
        public WorkItemService(AppDbContext context)
        {
            unitOfWork = new UnitOfWork(context);
        }
        public WorkItemViewModel GetWokItemById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<WorkItemDto> GetWorkItems()
        {
            throw new System.NotImplementedException();
        }

        public void AddWorkItem(WorkItemDto workItem)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateWorkItem(WorkItemDto workItem)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteWorkItem(WorkItemDto workItem)
        {
            throw new System.NotImplementedException();
        }
    }
}
using System.Collections.Generic;
using DecadenceV2_1_DAL.Entities;
using DecadenceV2_1_DAL.Interfaces;
using DecadenceV2_1_DAL.Interfaces.IServices;
using DecadenceV2_1_DAL.UnitOfWork;

namespace DecadenceV2_1_DAL.Services
{
    public class WorkItemService: IWorkItemService
    {
        IUnitOfWork _unitOfWork;

        public WorkItemService(AppDataContext context)
        {
            _unitOfWork = new UnitOfWork.UnitOfWork(context);
        }

        public void AddWorkItem(WorkItem item)
        {
            _unitOfWork.WorkItemRepository.Add(item);
        }

        public void UpdateWorkItem(WorkItem item)
        {
            _unitOfWork.WorkItemRepository.Update(item);
        }

        public void DeleteWorkItem(WorkItem item)
        {
            _unitOfWork.WorkItemRepository.Delete(item);
        }

        public WorkItem GetWorkItemById(int id)
        {
            return _unitOfWork.WorkItemRepository.GetById(id);
        }

        public IEnumerable<WorkItem> GetAllWorkItems()
        {
            return _unitOfWork.WorkItemRepository.GetAll();
        }
    }
}
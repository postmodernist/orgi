using System;
using System.Collections.Generic;
using Decadence_DAL.Entities;
using Decadence_DAL.Interfaces;

namespace Decadence_DAL.Services
{
    public class WorkItemService: IWorkItemService
    {
        IUnitOfWork _unitOfWork;

        public WorkItemService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Guid AddWorkItem(WorkItem item)
        {
            return _unitOfWork.WorkItemRepository.Add(item);
        }

        public void UpdateWorkItem(WorkItem item)
        {
            _unitOfWork.WorkItemRepository.Update(item);
        }

        public void DeleteWorkItem(WorkItem item)
        {
            _unitOfWork.WorkItemRepository.Delete(item);
        }

        public WorkItem GetWorkItemById(Guid id)
        {
            return _unitOfWork.WorkItemRepository.Get(id);
        }

        public IEnumerable<WorkItem> GetAllWorkItems()
        {
            return _unitOfWork.WorkItemRepository.GetAll();
        }
    }
}
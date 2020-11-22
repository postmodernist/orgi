using Decadence_DAL.Entities;
using Decadence_DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace Decadence_DAL.Services
{
    public class WorkItemService : IWorkItemService
    {
        IUnitOfWork _unitOfWork;

        public WorkItemService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int AddWorkItem(WorkItem item)
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

        public WorkItem GetWorkItemById(int id)
        {
            return _unitOfWork.WorkItemRepository.Get(id);
        }

        public IEnumerable<WorkItem> GetAllWorkItems()
        {
            return _unitOfWork.WorkItemRepository.GetAll();
        }
    }
}
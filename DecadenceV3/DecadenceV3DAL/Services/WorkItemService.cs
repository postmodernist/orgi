using System.Collections.Generic;
using AutoMapper;
using DecadenceV3BLL.DTOs;
using DecadenceV3BLL.Interfaces.Services;
using DecadenceV3BLL.ViewModels;
using DecadenceV3DAL.Entities;
using DecadenceV3DAL.Interfaces;
using DecadenceV3DAL.UnitOfWork;

namespace DecadenceV3BLL.Services
{
    public class WorkItemService: IWorkItemService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;
        public WorkItemService(AppDbContext context, IMapper mapper)
        {
            unitOfWork = new UnitOfWork(context);
            _mapper = mapper;
        }
        public WorkItemDto GetWokItemById(int id)
        {
            return _mapper.Map<WorkItemDto>(unitOfWork.WorkItemRepository.GetEntityById(id));
        }

        public IEnumerable<WorkItemDto> GetWorkItems()
        {
            return _mapper.Map<IEnumerable<WorkItemDto>>(unitOfWork.WorkItemRepository.GetEntities());
        }

        public void AddWorkItem(WorkItemDto workItem)
        {
            var item = _mapper.Map<WorkItem>(workItem);
            unitOfWork.WorkItemRepository.Add(item);
        }

        public void UpdateWorkItem(WorkItemDto workItem)
        {
            var item = _mapper.Map<WorkItem>(workItem);
            unitOfWork.WorkItemRepository.Update(item);
        }

        public void DeleteWorkItem(WorkItemDto workItem)
        {
            var item = _mapper.Map<WorkItem>(workItem);
            unitOfWork.WorkItemRepository.Delete(item);
        }
    }
}
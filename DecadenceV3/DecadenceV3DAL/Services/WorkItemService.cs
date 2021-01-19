using System.Collections.Generic;
using System.Threading.Tasks;
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
        public async Task<WorkItemDto> GetWokItemById(int id)
        {
            return _mapper.Map<WorkItemDto>(await unitOfWork.WorkItemRepository.GetEntityById(id));
        }

        public async Task<IEnumerable<WorkItemDto>> GetWorkItems()
        {
            return _mapper.Map<IEnumerable<WorkItemDto>>(await unitOfWork.WorkItemRepository.GetEntities());
        }

        public async Task AddWorkItem(WorkItemDto workItem)
        {
            var item = _mapper.Map<WorkItem>(workItem);
            await unitOfWork.WorkItemRepository.Add(item);
        }

        public async Task UpdateWorkItem(WorkItemDto workItem)
        {
            var item = _mapper.Map<WorkItem>(workItem);
            await  unitOfWork.WorkItemRepository.Update(item);
        }

        public async Task DeleteWorkItem(WorkItemDto workItem)
        {
            var item = _mapper.Map<WorkItem>(workItem);
            await unitOfWork.WorkItemRepository.Delete(item);
        }
    }
}
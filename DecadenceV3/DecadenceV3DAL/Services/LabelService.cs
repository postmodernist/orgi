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
    public class LabelService: ILabelService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;
        public LabelService(AppDbContext context, IMapper mapper)
        {
            unitOfWork = new UnitOfWork(context);
            _mapper = mapper;
        }
        public async Task<LabelDto> GetLabelById(int id)
        {
            return _mapper.Map<LabelDto>(await unitOfWork.LabelRepository.GetEntityById(id));
        }

        public async Task<IEnumerable<LabelDto>> GetLabels()
        {
            return _mapper.Map<IEnumerable<LabelDto>>(await unitOfWork.LabelRepository.GetEntities());
        }

        public async Task AddLabel(LabelDto label)
        {
            var item = _mapper.Map<Label>(label);
            await unitOfWork.LabelRepository.Add(item);
        }

        public async Task UpdateLabel(LabelDto label)
        {
            var item = _mapper.Map<Label>(label);
            await unitOfWork.LabelRepository.Update(item);
        }

        public async Task DeleteLabel(LabelDto label)
        {
            var item = _mapper.Map<Label>(label);
            await unitOfWork.LabelRepository.Delete(item);
        }
    }
}
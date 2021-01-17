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
    public class LabelService: ILabelService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;
        public LabelService(AppDbContext context, IMapper mapper)
        {
            unitOfWork = new UnitOfWork(context);
            _mapper = mapper;
        }
        public LabelDto GetLabelById(int id)
        {
            return _mapper.Map<LabelDto>(unitOfWork.LabelRepository.GetEntityById(id));
        }

        public IEnumerable<LabelDto> GetLabels()
        {
            return _mapper.Map<IEnumerable<LabelDto>>(unitOfWork.LabelRepository.GetEntities());
        }

        public void AddLabel(LabelDto label)
        {
            var item = _mapper.Map<Label>(label);
            unitOfWork.LabelRepository.Add(item);
        }

        public void UpdateLabel(LabelDto label)
        {
            var item = _mapper.Map<Label>(label);
            unitOfWork.LabelRepository.Update(item);
        }

        public void DeleteLabel(LabelDto label)
        {
            var item = _mapper.Map<Label>(label);
            unitOfWork.LabelRepository.Delete(item);
        }
    }
}
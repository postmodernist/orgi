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
    public class FilterService: IFilterService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;
        public FilterService(AppDbContext context, IMapper mapper)
        {
            unitOfWork = new UnitOfWork(context);
            _mapper = mapper;
        }
        public FilterDto GetFilterById(int id)
        {
            return _mapper.Map<FilterDto>(unitOfWork.FilterRepository.GetEntityById(id));
        }

        public IEnumerable<FilterDto> GetFilters()
        {
            return _mapper.Map<IEnumerable<FilterDto>>(unitOfWork.FilterRepository.GetEntities());
        }

        public void AddFilter(FilterDto filter)
        {
            var item = _mapper.Map<Filter>(filter);
            unitOfWork.FilterRepository.Add(item);
        }

        public void UpdateFilter(FilterDto filter)
        {
            var item = _mapper.Map<Filter>(filter);
            unitOfWork.FilterRepository.Update(item);
        }

        public void DeleteFilter(FilterDto filter)
        {
            var item = _mapper.Map<Filter>(filter);
            unitOfWork.FilterRepository.Delete(item);
        }
    }
}
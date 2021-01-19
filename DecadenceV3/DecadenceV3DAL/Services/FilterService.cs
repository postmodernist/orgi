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
    public class FilterService: IFilterService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;
        public FilterService(AppDbContext context, IMapper mapper)
        {
            unitOfWork = new UnitOfWork(context);
            _mapper = mapper;
        }
        public async Task<FilterDto> GetFilterById(int id)
        {
            return _mapper.Map<FilterDto>(await unitOfWork.FilterRepository.GetEntityById(id));
        }

        public async Task <IEnumerable<FilterDto>> GetFilters()
        {
            return _mapper.Map<IEnumerable<FilterDto>>(await  unitOfWork.FilterRepository.GetEntities());
        }

        public async Task AddFilter(FilterDto filter)
        {
            var item = _mapper.Map<Filter>(filter);
            await unitOfWork.FilterRepository.Add(item);
        }

        public async Task UpdateFilter(FilterDto filter)
        {
            var item = _mapper.Map<Filter>(filter);
            await unitOfWork.FilterRepository.Update(item);
        }

        public async Task DeleteFilter(FilterDto filter)
        {
            var item = _mapper.Map<Filter>(filter);
            await unitOfWork.FilterRepository.Delete(item);
        }
    }
}
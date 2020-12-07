using System.Collections.Generic;
using DecadenceV2_DAL.Entities;
using DecadenceV2_DAL.Interfaces;
using DecadenceV2_DAL.Interfaces.IServices;
using DecadenceV2_DAL.UnitOfWork;

namespace DecadenceV2_DAL.Services
{
    public class FilterService: IFilterService
    {
        IUnitOfWork _unitOfWork;
        public FilterService(AppDataContext context)
        {
            _unitOfWork = new UnitOfWork.UnitOfWork(context);
        }

        public void AddFilter(Filter filter)
        {
            _unitOfWork.FilterRepository.Add(filter);
        }

        public void DeleteFilter(Filter filter)
        {
            _unitOfWork.FilterRepository.Delete(filter);
        }

        public IEnumerable<Filter> GetAllFilters()
        {
            return _unitOfWork.FilterRepository.GetAll();
        }

        public Filter GetFilterById(int id)
        {
            return _unitOfWork.FilterRepository.GetById(id);
        }

        public void UpdateFilter(Filter filter)
        {
            _unitOfWork.FilterRepository.Update(filter);
        }
    }
}
using Decadence_DAL.Entities;
using Decadence_DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace Decadence_DAL.Services
{
    public class FilterService : IFilterService
    {
        IUnitOfWork _unitOfWork;
        public FilterService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public int AddFilter(Filter filter)
        {
            return _unitOfWork.FilterRepository.Add(filter);
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
            return _unitOfWork.FilterRepository.Get(id);
        }

        public void UpdateFilter(Filter filter)
        {
            _unitOfWork.FilterRepository.Update(filter);
        }
    }
}
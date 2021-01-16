using System.Collections.Generic;
using DecadenceV3BLL.DTOs;
using DecadenceV3BLL.Interfaces.Services;
using DecadenceV3BLL.ViewModels;
using DecadenceV3DAL.Interfaces;
using DecadenceV3DAL.UnitOfWork;

namespace DecadenceV3BLL.Services
{
    public class FilterService: IFilterService
    {
        private readonly IUnitOfWork unitOfWork;

        public FilterService(AppDbContext context)
        {
            unitOfWork = new UnitOfWork(context);
        }
        public FilterViewModel GetFilterById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<FilterDto> GetFilters()
        {
            throw new System.NotImplementedException();
        }

        public void AddFilter(FilterDto filter)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateFilter(FilterDto filter)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteFilter(FilterDto filter)
        {
            throw new System.NotImplementedException();
        }
    }
}
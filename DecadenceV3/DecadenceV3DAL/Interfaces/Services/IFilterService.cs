using System.Collections.Generic;
using DecadenceV3BLL.DTOs;
using DecadenceV3BLL.ViewModels;

namespace DecadenceV3BLL.Interfaces.Services
{
    public interface IFilterService
    {
        FilterViewModel GetFilterById(int id);
        IEnumerable<FilterDto> GetFilters();
        void AddFilter(FilterDto filter);
        void UpdateFilter(FilterDto filter);
        void DeleteFilter(FilterDto filter);
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using DecadenceV3BLL.DTOs;
using DecadenceV3BLL.ViewModels;

namespace DecadenceV3BLL.Interfaces.Services
{
    public interface IFilterService
    {
        Task<FilterDto> GetFilterById(int id);
        Task<IEnumerable<FilterDto>> GetFilters();
        Task AddFilter(FilterDto filter);
        Task UpdateFilter(FilterDto filter);
        Task DeleteFilter(FilterDto filter);
    }
}
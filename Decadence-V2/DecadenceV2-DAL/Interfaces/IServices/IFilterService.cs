using System.Collections.Generic;
using DecadenceV2_DAL.Entities;

namespace DecadenceV2_DAL.Interfaces.IServices
{
    public interface IFilterService
    {
        void AddFilter(Filter filter);
        void UpdateFilter(Filter filter);
        void DeleteFilter(Filter filter);
        Filter GetFilterById(int id);
        IEnumerable<Filter> GetAllFilters();
    }
}
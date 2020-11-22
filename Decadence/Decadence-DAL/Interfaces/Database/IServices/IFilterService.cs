using Decadence_DAL.Entities;
using System;
using System.Collections.Generic;

namespace Decadence_DAL.Interfaces
{
    public interface IFilterService
    {
        int AddFilter(Filter filter);
        void UpdateFilter(Filter filter);
        void DeleteFilter(Filter filter);
        Filter GetFilterById(int id);
        IEnumerable<Filter> GetAllFilters();
    }
}

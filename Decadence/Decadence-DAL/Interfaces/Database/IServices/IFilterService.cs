using System;
using System.Collections.Generic;
using System.Text;
using Decadence_DAL.Entities;

namespace Decadence_DAL.Interfaces.Database.IServices
{
    interface IFilterService
    {
        Guid AddFilter(Filter filter);
        void UpdateFilter(Filter filter);
        void DeleteFilter(Filter filter);
        Filter GetFilterById(Guid id);
        IEnumerable<Filter> GetAllFilters();
    }
}

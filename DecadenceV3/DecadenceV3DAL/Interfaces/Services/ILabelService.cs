using System.Collections.Generic;
using DecadenceV3BLL.DTOs;
using DecadenceV3BLL.ViewModels;

namespace DecadenceV3BLL.Interfaces.Services
{
    public interface ILabelService
    {
        LabelDto GetLabelById(int id);
        IEnumerable<LabelDto> GetLabels();
        void AddLabel(LabelDto label);
        void UpdateLabel(LabelDto label);
        void DeleteLabel(LabelDto label);
    }
}
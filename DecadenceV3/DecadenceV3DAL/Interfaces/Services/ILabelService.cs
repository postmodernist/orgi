using System.Collections.Generic;
using System.Threading.Tasks;
using DecadenceV3BLL.DTOs;
using DecadenceV3BLL.ViewModels;

namespace DecadenceV3BLL.Interfaces.Services
{
    public interface ILabelService
    {
        Task<LabelDto> GetLabelById(int id);
        Task<IEnumerable<LabelDto>> GetLabels();
        Task AddLabel(LabelDto label);
        Task UpdateLabel(LabelDto label);
        Task DeleteLabel(LabelDto label);
    }
}
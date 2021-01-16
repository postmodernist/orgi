using System.Collections.Generic;
using DecadenceV3BLL.DTOs;
using DecadenceV3BLL.Interfaces.Services;
using DecadenceV3BLL.ViewModels;
using DecadenceV3DAL.Interfaces;
using DecadenceV3DAL.UnitOfWork;

namespace DecadenceV3BLL.Services
{
    public class LabelService: ILabelService
    {
        private readonly IUnitOfWork unitOfWork;

        public LabelService(AppDbContext context)
        {
            unitOfWork = new UnitOfWork(context);
        }
        public LabelViewModel GetLabelById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<LabelDto> GetLabels()
        {
            throw new System.NotImplementedException();
        }

        public void AddLabel(LabelDto label)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateLabel(LabelDto label)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteLabel(LabelDto label)
        {
            throw new System.NotImplementedException();
        }
    }
}
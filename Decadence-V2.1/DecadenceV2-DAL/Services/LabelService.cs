using System.Collections.Generic;
using DecadenceV2_1_DAL.Entities;
using DecadenceV2_1_DAL.Interfaces;
using DecadenceV2_1_DAL.Interfaces.IServices;
using DecadenceV2_1_DAL.UnitOfWork;

namespace DecadenceV2_1_DAL.Services
{
    public class LabelService: ILabelService
    {
        IUnitOfWork _unitOfWork;

        public LabelService(AppDataContext context)
        {
            _unitOfWork = new UnitOfWork.UnitOfWork(context);
        }

        public void AddLabel(Label label)
        {
            _unitOfWork.LabelRepository.Add(label);
        }

        public void UpdateLabel(Label label)
        {
            _unitOfWork.LabelRepository.Update(label);
        }

        public void DeleteLabel(Label label)
        {
            _unitOfWork.LabelRepository.Delete(label);
        }

        public Label GetLabelById(int id)
        {
            return _unitOfWork.LabelRepository.GetById(id);
        }

        public IEnumerable<Label> GetAllLabels()
        {
            return _unitOfWork.LabelRepository.GetAll();
        }
    }
}
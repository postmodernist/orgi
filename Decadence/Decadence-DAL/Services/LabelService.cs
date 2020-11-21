using System;
using System.Collections.Generic;
using Decadence_DAL.Entities;
using Decadence_DAL.Interfaces;

namespace Decadence_DAL.Services
{
    public class LabelService: ILabelService
    {
        IUnitOfWork _unitOfWork;

        public LabelService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Guid AddLabel(Label label)
        {
            return _unitOfWork.LabelRepository.Add(label);
        }

        public void UpdateLabel(Label label)
        {
            _unitOfWork.LabelRepository.Update(label);
        }

        public void DeleteLabel(Label label)
        {
            _unitOfWork.LabelRepository.Delete(label);
        }

        public Label GetLabelById(Guid id)
        {
            return _unitOfWork.LabelRepository.Get(id);
        }

        public IEnumerable<Label> GetAllLabels()
        {
            return _unitOfWork.LabelRepository.GetAll();
        }
    }
}
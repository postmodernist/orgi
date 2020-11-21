using System;
using System.Collections.Generic;
using Decadence_DAL.Entities;

namespace Decadence_DAL.Interfaces
{
    public interface ILabelService
    {
        Guid AddLabel(Label label);
        void UpdateLabel(Label label);
        void DeleteLabel(Label label);
        Label GetLabelById(Guid id);
        IEnumerable<Label> GetAllLabels();
    }
}
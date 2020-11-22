using Decadence_DAL.Entities;
using System;
using System.Collections.Generic;

namespace Decadence_DAL.Interfaces
{
    public interface ILabelService
    {
        int AddLabel(Label label);
        void UpdateLabel(Label label);
        void DeleteLabel(Label label);
        Label GetLabelById(int id);
        IEnumerable<Label> GetAllLabels();
    }
}
﻿using System.Collections.Generic;
using DecadenceV2_DAL.Entities;

namespace DecadenceV2_DAL.Interfaces.IServices
{
    public interface ILabelService
    {
        void AddLabel(Label label);
        void UpdateLabel(Label label);
        void DeleteLabel(Label label);
        Label GetLabelById(int id);
        IEnumerable<Label> GetAllLabels();
    }
}
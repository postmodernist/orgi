using System;
using System.Collections.Generic;
using System.Text;
using Decadence_DAL.Interfaces;

namespace Decadence_DAL.Entities
{
    public class Filter: IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Condition { get; set; }
    }
}

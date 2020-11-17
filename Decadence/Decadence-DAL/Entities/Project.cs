using System;
using System.Collections.Generic;
using Decadence_DAL.Interfaces;

namespace Decadence_DAL.Entities
{
    public class Project: IEntity
    { 
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ColorMarker { get; set; }
        public bool isFavorite { get; set; }
        public string DisplayAs { get; set; }
        public ICollection<WorkItem> Tasks { get; set; }
        public Project SubProject { get; set; }
    }
}

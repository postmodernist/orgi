using Decadence_DAL.Interfaces;
using System;
using System.Collections.Generic;

namespace Decadence_DAL.Entities
{
    public class Project : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ColorMarker { get; set; }
        public bool isFavorite { get; set; }
        public string DisplayAs { get; set; }
        public ICollection<WorkItem> Tasks { get; set; }
        public Guid SubProjectId { get; set; }
    }
}

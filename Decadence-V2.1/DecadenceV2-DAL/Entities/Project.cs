using System;
using System.Collections.Generic;
using DecadenceV2_1_DAL.Interfaces.Entity;

namespace DecadenceV2_1_DAL.Entities
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
        public int SubProjectId { get; set; }
    }
}
using System.Collections.Generic;

namespace DecadenceV3DAL.Entities
{
    public class Project: Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ColorMarker { get; set; }
        public bool isFavorite { get; set; }
        public string DisplayAs { get; set; }
        public int SubProjectId { get; set; }
    }
}
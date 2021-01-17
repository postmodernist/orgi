using System.Collections.Generic;
using DecadenceV3BLL.DTOs;

namespace DecadenceV3BLL.ViewModels
{
    public class ProjectViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ColorMarker { get; set; }
        public bool isFavorite { get; set; }
        public string DisplayAs { get; set; }
        public IEnumerable<WorkItemDto> Tasks { get; set; }

    }
}
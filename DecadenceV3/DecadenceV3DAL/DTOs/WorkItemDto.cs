using System;

namespace DecadenceV3BLL.DTOs
{
    public class WorkItemDto
    {
        public string Name { get; set; }
        public string Priority { get; set; } // Default 0/minimal;
        public string Comment { get; set; }     //Nullable
        public DateTime ScheduleDay { get; set; } // Nullable
        public DateTime CreatedAt { get; set; }
        public int ProjectId { get; set; } //Nullable
        public int SubTaskId { get; set; } //Nullable
    }
}
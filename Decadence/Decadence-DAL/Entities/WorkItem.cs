using Decadence_DAL.Interfaces;
using System;

namespace Decadence_DAL.Entities
{
    public class WorkItem : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Priority { get; set; } // Default 0/minimal;
        public string Comment { get; set; }     //Nullable
        public DateTime ScheduleDay { get; set; } // Nullable
        public DateTime CreatedAt { get; set; }
        public Guid ProjectId { get; set; } //Nullable
        public Guid SubTaskId { get; set; } //Nullable
    }
}

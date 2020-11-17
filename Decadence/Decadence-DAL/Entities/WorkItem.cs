using System;
using Decadence_DAL.Interfaces;

namespace Decadence_DAL.Entities
{
    public class WorkItem: IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Priority { get; set; } // Default 0/minimal;
        public string Comment { get; set; }     //Nullable
        public DateTime ScheduleDay { get; set; } // Nullable
        public DateTime CreatedAt { get; set; }
        public Label Label { get; set; } //Nullable
        public WorkItem SubTask { get; set; } //Nullable
    }
}

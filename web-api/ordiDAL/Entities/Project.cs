using System;
using System.Collections.Generic;
using System.Text;

namespace ordiDAL.Entities
{
    class Project
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string ColorMarker { get; set; }
        public string DisplayStyle { get; set; } //board or list
        public DateTime created_at { get; set; }
        public DateTime last_updated_at { get; set; }
        public int UserID { get; set; }
        public virtual User Author { get; set; }
        public ICollection<WorkTask> Tasks { get; set; }
    }
}

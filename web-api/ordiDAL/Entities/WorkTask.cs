using System;
using System.Collections.Generic;
using System.Text;

namespace ordiDAL.Entities
{
    class WorkTask
    {
        
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public int Priority { get; set; }
        public DateTime ScheduleDUE { get; set; }
        public DateTime created_at { get; set; }
        public DateTime last_updated_at { get; set; }
        public int UserID { get; set; }
        public int ProjectID { get; set; }
        public virtual Project Project { get; set; }
        public virtual User Author { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ordiDAL.Entities
{
    class Label
    {
        public int LabelID { get; set; }
        public string Name { get; set; }
        public int UserID { get; set; }
        public virtual User Author { get; set; }
        public ICollection<WorkTask> Tasks { get; set; }
    }
}

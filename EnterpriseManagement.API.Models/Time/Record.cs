using System;
using System.Collections.Generic;

namespace EnterpriseManagement.API.Models.Time
{
    public class Record : BaseEntity
    {
        public Record()
        {            
            Details = new HashSet<RecordTaskDetail>();
        }

        public int Sequence { get; set; }
        public DateTime StartTime { get; set; }                
        public virtual ICollection<RecordTaskDetail> Details { get; set; }        
    }
}

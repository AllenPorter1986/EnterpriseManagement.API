using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Models.TimeManagement
{
    public class Record : BaseEntity
    {
        public Record()
        {
            TimeSheetRecords = new HashSet<TimeSheetRecord>();
            Details = new HashSet<Task>();
        }

        public DateTime StartTime { get; set; }                
        public virtual ICollection<Task> Details { get; set; }

        // Navigation Properties
        public virtual ICollection<TimeSheetRecord> TimeSheetRecords { get; set; }
    }
}

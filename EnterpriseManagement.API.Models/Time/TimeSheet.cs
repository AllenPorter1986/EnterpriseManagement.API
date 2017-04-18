using EnterpriseManagement.Models.TimeManagment.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Models.TimeManagement
{
    public class TimeSheet : BaseEntity
    {
        public TimeSheet()
        {
            TimeSheetRecords = new HashSet<TimeSheetRecord>();
        }

        public int EmployeeId { get; set; }
        public TimeSheetStatus Status { get; set; }
        public ICollection<TimeSheetRecord> TimeSheetRecords { get; set; }

        // Navigation Properties
        public Employee Employee { get; set; }
    }
}

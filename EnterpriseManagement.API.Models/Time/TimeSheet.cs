using EnterpriseManagement.API.Models.TimeManagment.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.API.Models.Time
{
    public class TimeSheet : BaseEntity
    {
        public TimeSheet()
        {
            Records = new HashSet<Record>();
        }

        public int EmployeeId { get; set; }
        public TimeSheetStatus Status { get; set; }
        public ICollection<Record> Records { get; set; }

        // Navigation Properties
        public Employee Employee { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Models.TimeManagement
{
    public class TimeSheetRecord
    {
        [Key]
        [Column(Order = 1)]
        public int TimeSheetId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int RecordId { get; set; }
        public int Sequence { get; set; }
        [ForeignKey("TimeSheetId")]
        public virtual TimeSheet TimeSheet { get; set; }
        [ForeignKey("RecordId")]
        public virtual Record Record { get; set; }

    }
}

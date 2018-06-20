using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.API.Models.Time
{
    public class RecordTaskDetail
    {
        [Key]
        [Column(Order = 1)]
        public int RecordId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int TaskId { get; set; }
        [ForeignKey("TaskDetailId")]
        public virtual Record Record { get; set; }
        [ForeignKey("TaskDetailId")]
        public virtual TaskDetail TaskDetail { get; set; }
    }
}

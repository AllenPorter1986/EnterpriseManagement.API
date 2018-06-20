using EnterpriseManagement.API.Models;
using System.Collections.Generic;

namespace EnterpriseManagement.API.Models.Time
{
    public class Task : BaseEntity
    {
        public Task()
        {
            Details = new HashSet<TaskDetail>();
        }

        public int? ClientId { get; set; }
        public ICollection<TaskDetail> Details { get; set; }

        // Navigation Properties
        public virtual Client Client { get; set; }
        public virtual Function Function { get; set; }
    }
}

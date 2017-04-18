using EnterpriseManagement.Models.OrderManagement;
using System.Collections.Generic;

namespace EnterpriseManagement.Models.TimeManagement
{
    public class Task : BaseEntity
    {
        public Task()
        {
            Orders = new HashSet<Order>();
        }

        public int FunctionId { get; set; }
        public int? ClientId { get; set; }
        public ICollection<Order> Orders { get; set; }

        // Navigation Properties
        public virtual Client Client { get; set; }
        public virtual Function Function { get; set; }
    }
}

using System.Collections.Generic;

namespace EnterpriseManagement.Models.Fulfillment
{
    public class OrderDetail: BaseEntity
    {
        public int OrderId { get; set; } 
        public int Sequence { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual Order Order { get; set; }
    }
}

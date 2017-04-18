using EnterpriseManagement.Models.InventoryManagement;
using System.Collections.Generic;

namespace EnterpriseManagement.Models.OrderManagement
{
    public class OrderItem:BaseEntity
    {
        public OrderItem()
        {
            ItemLocationOrderItems = new HashSet<ItemLocationOrderItem>();
        }
        public int ItemId { get; set; }
        public int Quantity { get; set; }

        //Navigation Properties
        public virtual Item Item { get; set; }
        public virtual ICollection<ItemLocationOrderItem> ItemLocationOrderItems { get; set; }
    }
}

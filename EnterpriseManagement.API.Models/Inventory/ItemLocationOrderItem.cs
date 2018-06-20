using EnterpriseManagement.API.Models.Fulfillment;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EnterpriseManagement.API.Models.Inventory
{
    public class ItemLocationOrderItem
    {
        [Key]
        [Column(Order = 1)]
        public int OrderItemId { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ItemId { get; set; }
        [Key]
        [Column(Order = 3)]
        public int ItemLocationId { get; set; }
        public int Quantity { get; set; }

        //Navigation Properties
        public virtual OrderItem OrderItem { get; set; }        
        public virtual ItemLocation ItemLocation { get; set; }
    }
}

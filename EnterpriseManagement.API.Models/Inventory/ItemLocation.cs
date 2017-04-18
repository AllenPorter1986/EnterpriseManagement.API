using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Models.Inventory
{
    public class ItemLocation
    {
        public ItemLocation()
        {
            ItemLocationOrderItems = new HashSet<ItemLocationOrderItem>();
        }
        [Key]
        [Column(Order = 1)]
        public int ItemId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int LocationId { get; set; }
        public int Quantity { get; set; }
        public int QuantityMin { get; set; }
        public int QuantityMax { get; set; }

        //Navigation Properties
        public virtual ICollection<ItemLocationOrderItem> ItemLocationOrderItems { get; set; }
        [ForeignKey("ItemId")]
        public virtual Item Item { get; set; }
        [ForeignKey("LocationId")]
        public virtual Location Location { get; set; }

    }
}

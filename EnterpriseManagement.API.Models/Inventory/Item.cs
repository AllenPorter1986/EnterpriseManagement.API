using EnterpriseManagement.Models.Inventory.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Models.Inventory
{
   public class Item : BaseEntity
    {
        public Item()
        {
            ItemLocations = new HashSet<ItemLocation>();
        }
        public string Code { get; set; }
        public ItemType Type { get; set; }
        public ItemUnitType UnitType { get; set; }
        public virtual ICollection<ItemLocation> ItemLocations { get; set; }
    }
}

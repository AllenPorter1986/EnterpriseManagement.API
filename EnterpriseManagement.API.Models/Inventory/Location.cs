using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.API.Models.Inventory
{
    public class Location : PostionalBaseEntity<LocationVector>
    {
        public Location()
        {
            ItemLocations = new HashSet<ItemLocation>();
        }

        public int AisleId { get; set; }
        public string Code { get; set; }
        public int Sequence { get; set; }
        public virtual ICollection<ItemLocation> ItemLocations { get; set; }        
        [ForeignKey("AisleId")]
        public virtual Aisle Aisle { get; set; }
        //TODO: Add Spatial Information

    }
}

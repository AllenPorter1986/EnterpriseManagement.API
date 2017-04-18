using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.Models.Inventory
{
    public class Aisle : BaseEntity
    {
        public Aisle()
        {
            Locations = new HashSet<Location>();
        }

        public int ZoneId { get; set; }
        public string Code { get; set; }
        public int Sequence { get; set; }

        public virtual ICollection<Location> Locations { get; set; }
        [ForeignKey("ZoneId")]
        public virtual Zone Zone { get; set; }
        //TODO: Add Spatial Information

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.API.Models.Inventory
{
    public class Zone :BaseEntity
    {        
        public int BuildingId { get; set; }
        public string Code { get; set; }
        public int Sequence { get; set; }
        public virtual ICollection<Aisle> Aisles { get; set; }

        [ForeignKey("BuildingId")]
        public virtual Building Building { get; set; }
        //TODO: Add Spatial Information

    }
}

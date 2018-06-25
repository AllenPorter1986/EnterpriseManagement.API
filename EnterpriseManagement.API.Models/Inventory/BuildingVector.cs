using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.API.Models.Inventory
{
    public class BuildingVector : VectorBaseEntity
    {
        public int BuildingId { get; set; }

        [ForeignKey("BuildingId")]
        public virtual Building Building { get; set; }
    }
}

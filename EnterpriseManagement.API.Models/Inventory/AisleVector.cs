using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.API.Models.Inventory
{
    public class AisleVector : VectorBaseEntity
    {
        public int AisleId { get; set; }

        [ForeignKey("AisleId")]
        public virtual Aisle Aisle { get; set; }
    }
}

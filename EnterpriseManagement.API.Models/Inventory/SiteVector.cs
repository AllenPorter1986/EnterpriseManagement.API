using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.API.Models.Inventory
{
    public class SiteVector : VectorBaseEntity
    {
        public int SiteId { get; set; }

        [ForeignKey("SiteId")]
        public virtual Site Site { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.API.Models.Inventory
{
    public class ObstacleVector : VectorBaseEntity
    {
        public int ObstacleId { get; set; }

        [ForeignKey("ObstacleId")]
        public virtual Obstacle Obstacle { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.API.Models.Inventory
{
    public class Building : BaseEntity
    {
        public Building()
        {
            Zones = new HashSet<Zone>();
            Obstacles = new HashSet<Obstacle>();
            Vectors = new HashSet<BuildingVector>();
        }

        public int SiteId { get; set; }
        public string Code { get; set; }
        public int Sequence { get; set; }
        public virtual ICollection<Zone> Zones { get; set; }
        public virtual ICollection<Obstacle> Obstacles { get; set; }
        public virtual ICollection<BuildingVector> Vectors { get; set; }
        public virtual Site Site { get; set; }
        //TODO: Add Spatial Information

    }
}

using System;
using System.Collections.Generic;

namespace EnterpriseManagement.API.ServiceModels.Inventory
{
    public class Building : PositionalModel
    {
        public int SiteId { get; set; }
        public string Code { get; set; }
        public int Sequence { get; set; }
        public List<Zone> Zones { get; set; }
        public List<Obstacle> Obstacles { get; set; }
    }
}
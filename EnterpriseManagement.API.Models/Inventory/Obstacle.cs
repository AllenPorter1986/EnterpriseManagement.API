﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.API.Models.Inventory
{
    public class Obstacle : PostionalBaseEntity<ObstacleVector>
    {        
        public int BuildingId { get; set; }
        public string Code { get; set; }
        public int Sequence { get; set; }

        [ForeignKey("BuildingId")]
        public virtual Building Building { get; set; }
    }
}

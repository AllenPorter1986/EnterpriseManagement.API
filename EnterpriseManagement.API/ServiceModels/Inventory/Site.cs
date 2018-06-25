using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterpriseManagement.API.ServiceModels.Inventory
{
    public class Site : PositionalModel
    {
        public string Code { get; set; }
        public int Sequence { get; set; }
        public List<Building> Buildings { get; set; }
    }
}
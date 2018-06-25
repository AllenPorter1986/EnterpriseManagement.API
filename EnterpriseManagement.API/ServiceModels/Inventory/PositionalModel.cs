using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EnterpriseManagement.API.ServiceModels.Inventory
{
    public class PositionalModel : BaseModel
    {
        public List<Vector> Vectors { get; set; }
    }
}
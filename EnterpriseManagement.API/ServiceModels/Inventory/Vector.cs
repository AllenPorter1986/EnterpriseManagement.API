using System;

namespace EnterpriseManagement.API.ServiceModels.Inventory
{
    public class Vector: BaseModel
    {        
        public decimal? X { get; set; }
        public decimal? Y { get; set; }
        public decimal? Z { get; set; }
    }
}
using System.Collections.Generic;

namespace EnterpriseManagement.Models.Inventory
{
    public class Site : BaseEntity
    {
        public string Code { get; set; }
        public int Sequence { get; set; }
        public virtual ICollection<Building> Buildings { get; set; }
        
        //TODO: Add Spatial Information
    }
}

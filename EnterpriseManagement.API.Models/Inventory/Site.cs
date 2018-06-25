using System.Collections.Generic;

namespace EnterpriseManagement.API.Models.Inventory
{
    public class Site : PostionalBaseEntity<SiteVector>
    {
        public Site()
        {
            Buildings = new HashSet<Building>();
        }

        public string Code { get; set; }
        public int Sequence { get; set; }
        public virtual ICollection<Building> Buildings { get; set; }
    }
}

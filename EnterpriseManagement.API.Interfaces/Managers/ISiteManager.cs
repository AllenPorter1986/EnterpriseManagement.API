using EnterpriseManagement.API.Models.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.API.Interfaces.Managers
{
    public interface ISiteManager
    {
        List<Site> GetSites();
        Site GetSite(int id);
        void Create(Site site);
        void Update(int id, Site site);
        void Delete(int id);
    }
}

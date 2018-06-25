using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnterpriseManagement.API.Models.Inventory;

namespace EnterpriseManagement.API.Interfaces.Repositories
{
    public interface ISiteRepository
    {
        List<Site> GetSites();
        Site GetSite(int id);
        void Update(int id, Site site);
        void Create(Site site);
        void Delete(int id);
    }
}

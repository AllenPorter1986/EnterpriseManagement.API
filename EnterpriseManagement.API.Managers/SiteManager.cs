using EnterpriseManagement.API.Interfaces.Managers;
using EnterpriseManagement.API.Interfaces.Repositories;
using EnterpriseManagement.API.Models.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.API.Managers
{
    public class SiteManager : ISiteManager
    {
        private ISiteRepository _siteRepository;

        public SiteManager(ISiteRepository siteRepository)
        {
            _siteRepository = siteRepository;
        }

        public void Create(Site site)
        {
            _siteRepository.Create(site);
        }

        public void Delete(int id)
        {
            _siteRepository.Delete(id);
        }

        public Site GetSite(int id)
        {
            return _siteRepository.GetSite(id);
        }

        public List<Site> GetSites()
        {
            return _siteRepository.GetSites();
        }

        public void Update(int id, Site site)
        {
            _siteRepository.Update(id, site);
        }
    }
}

using AutoMapper;
using EnterpriseManagement.API.Interfaces.Managers;
using EnterpriseManagement.API.ServiceModels.Inventory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EnterpriseManagement.API.Controllers
{
    public class SitesController : ApiController
    {
        private ISiteManager _siteManager;
        private IMapper _mapper;

        public SitesController(ISiteManager siteManager, IMapper mapper)
        {
            _siteManager = siteManager;
            _mapper = mapper;
        }

        // GET: api/Sites
        public List<Site> Get()
        {
            var sites = _siteManager.GetSites();
            return _mapper.Map<List<Site>>(sites);
        }

        // GET: api/Sites/5
        public Site Get(int id)
        {
            var site = _siteManager.GetSite(id);
            return _mapper.Map<Site>(site);
        }

        // POST: api/Sites
        public void Post(Site site)
        {
            var siteToSave = _mapper.Map<Models.Inventory.Site>(site);
            _siteManager.Create(siteToSave);
        }

        // PUT: api/Sites/5
        public void Put(int id, Site site)
        {
            var siteToSave = _mapper.Map<Models.Inventory.Site>(site);
            _siteManager.Update(id, siteToSave);
        }

        // DELETE: api/Sites/5
        public void Delete(int id)
        {
            _siteManager.Delete(id);
        }
    }
}

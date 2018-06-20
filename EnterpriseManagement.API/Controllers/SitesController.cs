using EnterpriseManagement.API.Interfaces;
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

        public SitesController(ISiteManager siteManager)
        {
            _siteManager = siteManager;
        }

        // GET: api/Sites
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Sites/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Sites
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Sites/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Sites/5
        public void Delete(int id)
        {
        }
    }
}

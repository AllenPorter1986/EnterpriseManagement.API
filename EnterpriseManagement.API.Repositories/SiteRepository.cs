using EnterpriseManagement.API.Interfaces.Repositories;
using EnterpriseManagement.API.Models;
using EnterpriseManagement.API.Models.Inventory;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseManagement.API.Repositories
{
    public class SiteRepository : ISiteRepository
    {
        private EnterpriseManagementDbContext _dbContext;

        public SiteRepository()
        {
            _dbContext = new EnterpriseManagementDbContext();
        }

        public void Create(Site site)
        {
            _dbContext.Sites.Add(site);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetSite(id);

            if(entity == null)
            {
                return;
            }

            _dbContext.Sites.Remove(entity);
            _dbContext.SaveChanges();
        }

        public Site GetSite(int id)
        {
            return _dbContext.Sites
                .Where(s => s.Id == id)
                .Include(s => s.Vectors)
                .Include(s => s.Buildings)
                .FirstOrDefault();
        }

        public List<Site> GetSites()
        {
            return _dbContext.Sites.ToList();
        }

        public void Update(int id, Site site)
        {
            var entity = GetSite(id);

            if(entity == null)
            {
                return;
            }

            _dbContext.Entry(entity).CurrentValues.SetValues(site);
            _dbContext.SaveChanges();
        }
    }
}

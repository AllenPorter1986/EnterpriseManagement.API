using EnterpriseManagement.API.Interfaces;
using EnterpriseManagement.API.Managers;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace EnterpriseManagement.API
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<ISiteManager, SiteManager>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}
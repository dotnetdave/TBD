using DryIoc;
using DryIoc.Mvc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace TBD
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            var container = new Container();
            container.Register<ICustomerRepository, CustomerRepository>();
            container.WithMvc();
        }
    }

    public class CustomerRepository : ICustomerRepository
    {
        public string Test() => ConfigurationManager.AppSettings["Environment"];
    }

    public interface ICustomerRepository
    {
        string Test();
    }
}

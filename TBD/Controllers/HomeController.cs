using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TBD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICustomerRepository repo;

        public HomeController(ICustomerRepository repo)
        {
            this.repo = repo;
        }


        public ActionResult Index()
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            string version = fvi.FileVersion;


            var model = new IndexViewModelDave()
            {
                Version = version,
                Environment = repo.Test()
            };

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }

    public class IndexViewModelDave
    {
        public string Version { get; set; }
        public string Environment { get; set; }
    }
}
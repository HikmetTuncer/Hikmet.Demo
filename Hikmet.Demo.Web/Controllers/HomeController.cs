using Hikmet.Demo.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hikmet.Demo.Web.Controllers
{
    public class HomeController : Controller
    {
        private DemoDb _demodb = new DemoDb(); 

        public ActionResult Index()
        {
            var pizzas = _demodb.Pizzas.ToList();

            return View();
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
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc51ApplicationFx451.Controllers
{
    public class HomeController : Controller
    {
        class Foo { }
        static List<Foo> foos = new List<Foo>();

        public ActionResult Index()
        {
            for (int i = 0; i < 100; i++)
            {
                foos.Add(new Foo());
            }
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
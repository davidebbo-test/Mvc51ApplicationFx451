using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc51ApplicationFx451.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Trace.TraceInformation("This is an informational trace message");
            Trace.TraceWarning("Here is trace warning");
            Trace.TraceError("Something is broken; tracing an error!");

            return View();
        }

        public ActionResult About()
        {
            string blah = ConfigurationManager.AppSettings["blah"];
            ViewBag.Message = String.Format("The value of setting blah is: '{0}'", blah);

            return View();
        }


        private class Foo { }
        private static List<Foo> foos = new List<Foo>();

        public ActionResult Contact()
        {
            // Leak a bunch of objects for the fun of it!
            for (int i = 0; i < 100; i++)
            {
                foos.Add(new Foo());
            }

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
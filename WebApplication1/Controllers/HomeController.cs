using jsreport.MVC;
using jsreport.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [EnableJsReport()]
        public ActionResult Contact()
        {
            HttpContext.JsReportFeature()
                .Recipe(Recipe.PhantomPdf)
                .Configure((r) => r.Template.Phantom = new Phantom() { WaitForJS = true });
            return View();
        }
    }
}
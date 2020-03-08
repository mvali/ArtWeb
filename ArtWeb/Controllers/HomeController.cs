using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            //ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Education()
        {
            var eduw = new Models.EducationWorkVM()
            {
                Educations = new Models.Education().GetList(),
                Works = new Models.Work().GetList()
            };
            return PartialView(eduw);
        }
        public ActionResult Skills()
        {
            var items = new Models.Skill().GetList();
            return PartialView(items);
        }
        public ActionResult Slider()
        {
            var items = new Models.Slide().GetList();
            return PartialView("Slider", items);
        }
        public ActionResult Base64Encode()
        {
            var qs = Utils.Rq("c");
            var retV = Utils.Base64Encode(qs);
            Log.AddLogEntry("-" + retV);
            return PartialView("Error");
        }
        public ActionResult Base64Decode()
        {
            var qs = Utils.Rq("c");
            var retV = Utils.Base64Decode(qs);
            Log.AddLogEntry("-"+retV);
            return PartialView("Error");
        }

    }
}

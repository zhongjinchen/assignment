using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }

        //public JsonResult Index()
        //{
        //    return Json(
        //        new
        //        {
        //            age = 21
        //        },
        //        JsonRequestBehavior.AllowGet
        //    );
        //}

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


        [ChildActionOnly]
        public PartialViewResult Reminder()
        {
            return PartialView();
        }



    }
}
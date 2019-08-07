using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models.Publish;

namespace UI.Controllers
{
    public class PublishController : Controller
    {
        // GET: Publish
        public ActionResult Publish()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Publish(ProblemModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            return RedirectToAction("/Problem",model);
        }

        
        public ActionResult Problem(ProblemModel model)
        {
            return View(model);
        }
    }
}
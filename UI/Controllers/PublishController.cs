using MVCBLL.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Filters;
using UI.Models.Publish;

namespace UI.Controllers
{
    public class PublishController : Controller
    {
        public static IList<ProblemModel> problems { get; set; }

        // GET: Publish
        public ActionResult Publish()
        {
            return View();
        }

        [HttpPost]
        //[NeedLogOn]
        public ActionResult Publish(ProblemModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (problems == null)
            {
                problems = new List<ProblemModel>();
            }
            problems.Add(model);
            return RedirectToAction("/Problem",model);
        }

        
        public ActionResult Problem(ProblemModel model)
        {
            return View(model);
        }

        public ActionResult Single(int id)
        {
            ProblemModel model = Get(id);
            return View(model);
        }

        public ActionResult Post(int id,ProblemModel model)
        {
            ProblemModel problem = Get(id);
            problem.Comments = problem.Comments ?? new List<Comment>();
            problem.Comments.Add(model.Comment);

            return PartialView("Comments",model.Comment);
        }

        private ProblemModel Get(int id)
        {

           return problems[id];
        }

        //[NeedLogOn]
        //[ValidateAntiForgeryToken]
        public JsonResult Agree(int id)
        {
            return Json("点赞",JsonRequestBehavior.AllowGet);
        }
    }
}
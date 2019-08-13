using MVCBLL.Entitis;
using MVCService;
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
        //public static IList<ProblemModel> problems { get; set; }
        public ProblemService Service { get; set; }

        public PublishController()
        {
            Service = new ProblemService();
        }

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
            Problem problem = new Problem
            {
                Body = model.Body
            };
            int Id=Service.Save(problem).Id;
            return RedirectToAction($"/Single/{Id}");
        }

        
        public ActionResult Problem(ProblemModel model)
        {
            return View(model);
        }

        [HttpGet]
        public ActionResult Single(int id)
        {
            Problem problem =Service.GetById(id).SingleOrDefault();
            ProblemModel model = new ProblemModel
            {
                Body = problem.Body
            };

            if (problem.Comments!=null)
            {
                model.Comments = problem.Comments;
            }
            
            return View(model);
        }

        public ActionResult Post(int id,ProblemModel model)
        {
            Problem problem = null;
            if (Service.GetById(id)!=null)
            {
                 problem = Service.GetById(model.Id).SingleOrDefault();
            }
            
            
            problem.Comments.Add(model.Comment);

            return PartialView("Comments",model.Comment);
        }

        //[NeedLogOn]
        //[ValidateAntiForgeryToken]
        public JsonResult Agree(int id)
        {
            return Json("点赞",JsonRequestBehavior.AllowGet);
        }
    }
}
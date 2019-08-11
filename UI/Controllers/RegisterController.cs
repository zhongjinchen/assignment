using Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Filters;
using UI.Models.Register;

namespace UI.Controllers
{
    public class RegisterController : Controller
    {
        [ImportModelState]
        //[OutputCache(Duration=100,VaryByParam = "Id")]
        public ActionResult Index(int? Id )
        {
            //ModelState.Merge((ModelStateDictionary)TempData[Const.ErrorData]);

            ViewData[Const.Greet] = "Hello";
            IndexModel model = new IndexModel
            {
                Cites=new List<Cites>
                {
                    Cites.ChongQin,
                    Cites.HuNan
                }
            };
            return View(model);
        }

        [HttpPost]
        [AutoValidationFilter]
        public ActionResult Index(IndexModel model)
        {
            //if (!ModelState.IsValid)
            //{
            //    //return View(model);
            //    TempData[Const.ErrorData] = ModelState;
            //    return RedirectToAction("Index");
            //}

            if (model.Captcha != Session[Const.captcha].ToString())
            {
                ModelState.AddModelError(Const.Captcha, "* 验证码输入错误");
                return View(model);
            }

            return View(model);
        }

        public FileResult GetImg()
        {
            string filePath = Server.MapPath("/favicon.ico");
            return File(filePath,"ico","my.ico");
        }

        public ActionResult Get()
        {
            CaptchaCall captchaCall = new CaptchaCall();
            byte[] captcha = captchaCall.CreateCaptcha();
            Session[Const.captcha] = captchaCall.draw.Drawcode;
            return File(captcha, "jpg");
        }

        [HttpPost]
        public ViewResult Icon(HttpPostedFileWrapper icon)
        {
            string fileNema = Path.GetFileName(icon.FileName);
            icon.SaveAs(Path.Combine(Server.MapPath("~/Image"),fileNema));
            return View("Index");
        }
    }

    public enum Cites
    {
        HuNan,
        ChongQin
    }
}
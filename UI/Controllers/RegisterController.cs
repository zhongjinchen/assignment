using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models.Register;

namespace UI.Controllers
{
    public class RegisterController : Controller
    {
        public ActionResult Index()
        {
            ViewData[Const.Greet] = "Hello";
            IndexModel model = new IndexModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(IndexModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (model.Captcha != Session[Const.captcha].ToString())
            {
                ModelState.AddModelError(Const.Captcha, "* 验证码输入错误");
                return View(model);
            }

            return View(model);
        }

        public ActionResult Get()
        {
            CaptchaCall captchaCall = new CaptchaCall();
            byte[] captcha = captchaCall.CreateCaptcha();
            Session[Const.captcha] = captchaCall.draw.Drawcode;
            return File(captcha, "jpg");
        }
    }
}
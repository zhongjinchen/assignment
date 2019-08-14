using MVCService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models.Register;

namespace UI.Controllers
{
    public class LoginController : Controller
    {
        
        public UserService Service { get; set; }
        public LoginController()
        {
            Service = new UserService();
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(IndexModel model)
        {
            if (Service.GetByName(model.UserName)==null)
            {
                ModelState.AddModelError(model.UserName, "* 用户名不存在");
                return View();
            }

            if (!Service.PasswordCorrect(model.UserName,model.Password))
            {
                ModelState.AddModelError(model.Password, "* 密码错误");
                return View();
            }

            if (model.Captcha != Session[Const.captcha].ToString())
            {
                ModelState.AddModelError(Const.Captcha, "* 验证码输入错误");
                return View(model);
            }

            if (!ModelState.IsValid)
            {
                return View();
            }
          
            return View();
        }
    }
}
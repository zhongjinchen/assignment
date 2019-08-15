
using MVCBLL.Entitis;
using MVCService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Models.MVC17bangModels;

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
        public ActionResult Index(LoginModel model)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (Service.GetByName(model.UserName) == null)
            {
                ModelState.AddModelError(model.UserName, "* 用户名不存在");
                return View();
            }

            if (!Service.PasswordCorrect(model.UserName, model.Password))
            {
                ModelState.AddModelError(model.Password, "* 密码错误");
                return View();
            }

            if (model.Captcha != Session[Const.captcha].ToString())
            {
                ModelState.AddModelError(Const.Captcha, "* 验证码输入错误");
                return View(model);
            }

            //Response.Cookies[Const.COOKIE_USER][ConstRep.COOKIE_USERNAME] = user.UserName;
            //Response.Cookies[ConstRep.COOKIE_USER][ConstRep.COOKIE_PASSWORD] = user.Password;
            //Response.Cookies[ConstRep.COOKIE_USER].Expires = DateTime.Now.Add(new TimeSpan(7, 0, 0, 0, 0));

            User user = Service.GetByName(model.UserName).SingleOrDefault();
            Response.AppendCookie(
                new HttpCookie(Const.USER_ID, user.Id.ToString())
                {
                    Expires = DateTime.Now.AddMinutes(30)
                });
            Response.AppendCookie(
                new HttpCookie(Const.USER_PASSWORD, user.Password)
                {
                    Expires = DateTime.Now.AddMinutes(30)
                });
            Response.AppendCookie(
               new HttpCookie(Const.USER_NAME, Server.UrlEncode(user.Name))
               {
                   Expires = DateTime.Now.AddMinutes(30)
               });

            return View(model);
        }

        public ActionResult LoginOut()
        {
            HttpCookie User_IdCookie = new HttpCookie(Const.USER_ID);
            User_IdCookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(User_IdCookie);

            HttpCookie User_NameCookie = new HttpCookie(Const.USER_NAME);
            User_NameCookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(User_NameCookie);

            HttpCookie User_PasswordCookie = new HttpCookie(Const.USER_PASSWORD);
            User_PasswordCookie.Expires = DateTime.Now.AddDays(-1);
            Response.Cookies.Add(User_PasswordCookie);

            return Redirect(Request.Params["currentUser"]);
        }
    }
}
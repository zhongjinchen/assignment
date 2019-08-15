using MVCBLL.Entitis;
using MVCService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Filters
{
    public class NeedLogOnAttribute : AuthorizeAttribute
    {
        public UserService Service { get; set; }
        public NeedLogOnAttribute()
        {
            Service = new UserService();
        }
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            HttpContextBase context = filterContext.HttpContext;
            HttpCookie CookieUser = context.Request.Cookies[Const.USER_ID];
            
            if (CookieUser != null)
            {
                int UserId = Convert.ToInt32(CookieUser.Value);
                User user = Service.GetById(UserId).SingleOrDefault();
                if (user.Password== context.Request.Cookies["Password"].Value)
                {

                }
            }

            string currentPath = context.Request.Url.PathAndQuery;
            context.Response.Cookies.Add(new HttpCookie("prePage", currentPath));

            filterContext.Result = new RedirectResult("/");
            //base.OnAuthorization(filterContext);
        }

    }


}
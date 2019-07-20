using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Servise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace htmlCssBookStrap.Pages.Shared
{
    public class _LayoutModel:PageModel
    {
        protected const string userId = "userId";
        protected const string password = "password";
       
        public virtual void OnGet()
        {
            
            ViewData["UserName"] = HttpContext.Session.GetString("UserName");

            //string userIdValue;
            //if (Request.Cookies.TryGetValue(userId, out userIdValue))
            //{
            //    UserMode userMode = new UserService().GetById(Convert.ToInt32(userIdValue));
            //    if (userMode!=null)
            //    {
            //        if (Request.Cookies.TryGetValue(password,out string userAuthValue))
            //        {
            //            if (userAuthValue==userMode.MD5Password)
            //            {
            //                ViewData["UserName"] = userMode.Name;
            //            }
            //            else
            //            {
            //                Response.Cookies.Delete(userId);
            //                Response.Cookies.Delete(userIdValue);

            //            }
            //        }
            //    }
            //}
        }
    }
}

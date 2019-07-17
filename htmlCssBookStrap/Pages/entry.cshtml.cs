using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using htmlCssBookStrap.Pages;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Servise;

namespace htmlCssBookStrap.Pages
{
    [BindProperties]
    public class entryModel : PageModel
    {
        private const string _userId = "userId";
        private const string _password = "userId";
        private UserService _userService;
        public Register Register { get; set; }
        public void OnGet()
        {
            ViewData["title"] = "登陆";
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;       //return Page();
            }

            UserMode mode = _userService.GetUser(Register.UserName);

            if (mode==null)
            {
                ModelState.AddModelError("UserName","* 用户名不存在");
                return;
            }
            if(!_userService.PasswordCorrect(Register.Password,mode.MD5Password))
            {
                ModelState.AddModelError("UserName", "* 用户名或密码错误");
                return;
            }

            
            Response.Cookies.Append(_userId, mode.Id.ToString());
            Response.Cookies.Append(_password,mode.MD5Password);

 
        }
    }
}
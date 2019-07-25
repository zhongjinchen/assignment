using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using htmlCssBookStrap.Pages;
using htmlCssBookStrap.Pages.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Servise;

namespace htmlCssBookStrap.Pages
{
    [BindProperties]
    public class entryModel : _LayoutModel
    {
        private const string _userId = "userId";
        private const string _password = "password";
        private UserService _userService;
        public Forget Login { get; set; }

        public entryModel(UserService userService)
        {
            _userService = userService;
        }

        public override void OnGet()
        {
            
            base.OnGet();
            
        }

        public void OnPost()
        {
            
            if (!ModelState.IsValid)
            {
                return;       //return Page();
            }

            UserModel model = _userService.GetName(Login.UserName);

            if (model==null)
            {
                ModelState.AddModelError("Login.UserName", "* 用户名不存在");
                return;
            }
            if(!_userService.PasswordCorrect(Login.Password,model.MD5Password))
            {
                ModelState.AddModelError("Login.Password", "* 用户名或密码错误");
                return;
            }


            //Response.Cookies.Append(_userId, mode.Id.ToString(),
            //    new CookieOptions
            //    {
            //        //        //Domain = Request.Host.Value,
            //        //        Path="/entry",
            //        Expires = DateTime.Now.AddDays(1)//,
            //        //        IsEssential =true
            //    } 
            //    );
            //Response.Cookies.Append(_password,mode.MD5Password);

            HttpContext.Session.SetString("Id",JsonConvert.SerializeObject(model));

        }
    }


    public class Forget
    {

        [Required(ErrorMessage = " * 用户名不能为空")]
        public string UserName { get; set; }

        [Required(ErrorMessage = " * 密码不能为空")]
        [Display(Name = " * 密码")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = " * 验证码不能为空")]
        [Display(Name = " * 验证码")]
        public string identifyingCode { get; set; }
    }


}
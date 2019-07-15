using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Servise;

namespace htmlCssBookStrap.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        public Register Register { get; set; }
        public UserService _registerSevise;
        public IndexModel()
        {
            _registerSevise = new UserService();
        }
        public void OnGet()
        {
            ViewData["title"] = "注册";
        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;       //return Page();
            }
            //return RedirectToAction("About");

            if (_registerSevise.HasExist(Register.UserName))
            {
                ModelState.AddModelError("Register.UserName", "* 用户名重复");
                return;
            }

            _registerSevise.Register(Register.UserName,Register.Password);
        }

    }

    public class Register
    {
        [YZrequired]
        [Display(Name = " * 邀请人")]
        public string Inviter { get; set; }

        [YZrequired]
        [Display(Name = " * 邀请码")]
        public string UserName { get; set; }

        [YZrequired]
        [Display(Name =" * 用户名")]
        public string InvitationCode { get; set; }

        [YZrequired]
        [Display(Name = " * 密码")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [YZrequired]
        [Display(Name = " * 确认密码")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [YZrequired]
        [Display(Name = " * 验证码")]
        public string identifyingCode  { get; set; }
    }

    public class YZrequired : RequiredAttribute
    {
        public override string FormatErrorMessage(string name)
        {
            return $"{name}不能为空";
        }
    }
}

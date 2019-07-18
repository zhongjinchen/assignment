using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using htmlCssBookStrap.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Servise;

namespace htmlCssBookStrap.Pages
{
    [BindProperties]
    public class IndexModel : _LayoutModel
    {
        public Register Register { get; set; }
        public UserService _registerSevise;
        public IndexModel()
        {
            _registerSevise = new UserService();
        }
        public override void OnGet()
        {
            base.OnGet();
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
        [YZRegister]
        [Display(Name = " * 邀请人")]
        public string Inviter { get; set; }

        [YZRegister]
        [Display(Name = " * 邀请码")]
        public string InvitationCode { get; set; }

        [YZRegister]
        [Display(Name = " * 用户名")]
        public string UserName { get; set; }

        [YZRegister]
        [Display(Name = " * 密码")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [YZRegister]
        [Display(Name = " * 确认密码")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [YZRegister]
        [Display(Name = " * 验证码")]
        public string identifyingCode  { get; set; }
    }

    public class YZRegister : RequiredAttribute
    {
        public override string FormatErrorMessage(string name)
        {
            return $"{name}不能为空";
        }
    }
}

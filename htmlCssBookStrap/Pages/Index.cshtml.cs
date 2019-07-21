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
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();       //return Page();
            }
            try
            {
                if (Register.ConfirmPassword.GetType() == typeof(int))
                {
                    ViewData["IsNumber"] = true;
                    return Page();
                }
            }
            catch (Exception)
            {

              
            }
           
            if (_registerSevise.HasExist(Register.UserName))
            {
                ModelState.AddModelError("Register.UserName", "* 用户名重复");
                return Page();
            }

            _registerSevise.Register(Register.UserName,Register.Password,Register.Email);

            //return RedirectToPage("entry");

        }

    }

    public class Register
    {
        [Required(ErrorMessage = " * 邀请人不能为空")]
        [Display(Name = " * 邀请人")]
        public string Inviter { get; set; }

        [Required(ErrorMessage = " * 邀请码不能为空")]
        [Display(Name = " * 邀请码")]
        public string InvitationCode { get; set; }

        [Required(ErrorMessage = " * 用户名不能为空")]
        [Display(Name = " * 用户名")]
        [MaxLength(10,ErrorMessage = " * 用户名长度不能大于10")]
        public string UserName { get; set; }

        [Required(ErrorMessage = " * Email不能为空")]
        [EmailAddress(ErrorMessage ="* Email格式不正确")]
        public string Email { get; set; }

        [Required(ErrorMessage = " * 密码不能为空")]
        [Display(Name = " * 密码")]
        [MaxLength(20, ErrorMessage = "* 密码长度不能大于20")]
        [MinLength(6,ErrorMessage ="* 密码长度不能小于6")]
        [RegularExpression("[A-Za-z0-9]*", ErrorMessage ="* 密码只能为数字或字母")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = " * 确认密码不能为空")]
        [Display(Name = " * 确认密码")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage = "* 两次密码输入不一致")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = " * 验证码不能为空")]
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

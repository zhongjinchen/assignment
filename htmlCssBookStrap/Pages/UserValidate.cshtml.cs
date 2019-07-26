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
    public class UserValidateModel : _LayoutModel
    {
        private UserService _userSevise;

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        [Required(ErrorMessage = " * 密码不能为空")]
        [MaxLength(20, ErrorMessage = "* 密码长度不能大于20")]
        [MinLength(6, ErrorMessage = "* 密码长度不能小于6")]
        [RegularExpression("[A-Za-z0-9]*", ErrorMessage = "* 密码只能为数字或字母")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = " * 确认密码不能为空")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "* 两次密码输入不一致")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "* 验证码不能为空")]
        public string identifyingCode { get; set; }
        public override void OnGet()
        {
            
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();       //return Page();
            }
            try
            {
                if (ConfirmPassword.GetType() == typeof(int))
                {
                    ViewData["IsNumber"] = true;
                    return Page();
                }
            }
            catch (Exception)
            {


            }

            _userSevise.ResetPassword(Password, Id);

            return Redirect("entry");
        }
    }
}
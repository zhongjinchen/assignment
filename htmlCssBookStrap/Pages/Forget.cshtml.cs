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
    public class ForgetModel : _LayoutModel
    {
        public ForgetPassword ForgetPassword { get; set; }
        private UserService _userService;
        public override void OnGet()
        {

        }
        public void OnPost()
        {
            if (_userService.HasExist(ForgetPassword.UserName))
            {

            }
            if (_userService.HasExistEmail(ForgetPassword.Email))
            {

            }
        }
    }


    public class ForgetPassword
    {

        [Required(ErrorMessage = " * 用户名不能为空")]
        public string UserName { get; set; }

        [Required(ErrorMessage = " * Email不能为空")]
        public string Email { get; set; }

        [Required(ErrorMessage = " * 验证码不能为空")]
        public string identifyingCode { get; set; }
    }
}
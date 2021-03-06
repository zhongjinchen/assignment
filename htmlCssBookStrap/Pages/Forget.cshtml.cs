﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using htmlCssBookStrap.Pages.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Servise;

namespace htmlCssBookStrap.Pages
{
    [BindProperties]
    public class ForgetModel : _LayoutModel
    {
        private const string _id = "id";
        private const string _code = "code";
        public ForgetPassword ForgetPassword { get; set; }
        private UserService _userService;
        public ForgetModel(UserService userService)
        {
            _userService = userService;
        }
        public override void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (!_userService.HasExist(ForgetPassword.UserName))
            {
                ModelState.AddModelError("ForgetPassword.UserName", "* 用户名不存在");
                return Page();
            }
            if (!_userService.HasExistEmail(ForgetPassword.Email))
            {
                ModelState.AddModelError("ForgetPassword.Email", "* Email错误，请重新填写");
                return Page();
            }

            int CurrentUserId = _userService.GetName(ForgetPassword.UserName).UserModelId;

            //string ValidationUrlFormat =
            //    $"{Request.Scheme}://{Request.Host}/Forget/Validate?{_id}={CurrentUserId}";

            //_userService.SendValidationEmail(ForgetPassword.Email, ValidationUrlFormat);

            return Redirect($"/UserValidate?id={CurrentUserId}");

        }
    }


    public class ForgetPassword
    {

        [Required(ErrorMessage = " * 用户名不能为空")]
        public string UserName { get; set; }

        [Required(ErrorMessage = " * Email不能为空")]
        public string Email { get; set; }

        //[Required(ErrorMessage = " * 验证码不能为空")]
        //public string identifyingCode { get; set; }
    }
}
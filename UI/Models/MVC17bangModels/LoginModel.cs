using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Models.MVC17bangModels
{
    public class LoginModel
    {
        [Required]
        [Remote("IsNameDuplicated", "Register", ErrorMessage = "* 用户名重复", HttpMethod = "GET")]
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Captcha { get; set; }
    }
}
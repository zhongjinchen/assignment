using MVCBLL.Entitis;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UI.Controllers;
using CompareAttribute = System.Web.Mvc.CompareAttribute;

namespace UI.Models.Register
{
    public class IndexModel
    {
        [Required]
        [Remote("IsNameDuplicated", "Register", ErrorMessage = "* 用户名重复", HttpMethod = "GET")]
        public string UserName { get; set; }

        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "* 两次密码输入不一致")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = " * 邀请人不能为空")]
        public string Inviter { get; set; }

        [Required(ErrorMessage = " * 邀请码不能为空")]
        public string InvitationCode { get; set; }

        [Required(ErrorMessage = " * Email不能为空")]
        [EmailAddress(ErrorMessage = "* Email格式不正确")]
        public string Email { get; set; }

        public string Captcha { get; set; }

        public IList<Cites> Cites { get; set; } 

        public string aaa = "aaaaa";

    }
}
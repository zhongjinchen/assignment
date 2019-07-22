using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using htmlCssBookStrap.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace htmlCssBookStrap.Pages
{
    [BindProperties]
    public class UserValidateModel : _LayoutModel
    {
        [Required(ErrorMessage = "* 验证码不能为空")]
        public string identifyingCode { get; set; }
        public override void OnGet()
        {
            
        }
    }
}
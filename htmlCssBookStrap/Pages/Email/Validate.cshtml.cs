using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using htmlCssBookStrap.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Servise;

namespace htmlCssBookStrap.Pages.Email
{

    public class ValidateModel : _LayoutModel
    {
        private UserService _userService;
        private const string _id = "id";
        private const string _code = "code";
        public const string Valid = "valid";

        public ValidateModel(UserService userService)
        {
            _userService = userService;
        }

        [BindProperty]
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        public override void OnGet()
        {
            string Id = Request.Query[_id];
            string code = Request.Query[_code];
            if (!string.IsNullOrEmpty(Id) && !string.IsNullOrEmpty(code))
            {
                ViewData[Valid] = _userService.ValidationEmail(Convert.ToInt32(Id), code);
            }



        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            string ValidationUrlFormat =
                $"{Request.Scheme}://{Request.Host}/Email/Validate?{_code}={{0}}&{_id}={{1}}";

            _userService.SendValidationEmail(EmailAddress, ValidationUrlFormat);
        }
    }
}
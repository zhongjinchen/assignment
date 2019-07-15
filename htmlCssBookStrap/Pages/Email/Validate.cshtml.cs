using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Servise;

namespace htmlCssBookStrap.Pages.Email
{
    
    public class ValidateModel : PageModel
    {
        private UserService _userService;

        public ValidateModel()
        {
            _userService = new UserService();
        }

        [BindProperty]
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            string ValidationUrlFormat = 
                $"{Request.Scheme}://{Request.Host}/Email/Validation?code={{0}}&Id={{1}}";

            _userService.SendValidationEmail(EmailAddress,ValidationUrlFormat);
        }
    }
}
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
    public class ProblemSingleModel : _LayoutModel
    {
        public ProblemSingle ProblemSingle { get; set; }
        public override void OnGet()
        {
            string Id = Request.Query["id"];
            ViewData["id"] = Id;
        }
    }

    public class ProblemSingle
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }

    }
}
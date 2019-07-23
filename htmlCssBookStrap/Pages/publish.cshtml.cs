﻿using System;
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
    public class publishModel : _LayoutModel
    {
        public ProblemModel _problemModel { get; set; }
        public override void OnGet()
        {
      
        }
    }

    public class ProblemModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }

    }
}
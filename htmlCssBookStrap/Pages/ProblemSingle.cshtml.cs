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
    public class ProblemSingleModel : _LayoutModel
    {
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        //[Required]
        //public string Title { get; set; }
        //[Required]
        //public string Body { get; set; }
        //public ProblemSingleMessage ProblemSingleMessage { get; set; }

        private IProblemService _problemService;
        public DTOProblemModel DTOProblemModel { get; set; }
        public ProblemSingleModel(IProblemService problemService)
        {
            _problemService = problemService;
        }
        public override void OnGet()
        {
            //string Id = Request.Query["id"];
            ViewData["id"] = Id;

            DTOProblemModel = _problemService.Get(Id);
        }
    }

    public class ProblemSingleMessage
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Body { get; set; }

    }
}
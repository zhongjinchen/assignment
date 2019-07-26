using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using htmlCssBookStrap.Pages.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using Servise;

namespace htmlCssBookStrap.Pages
{
    [BindProperties]
    public class publishModel : _LayoutModel
    {
        //public ProblemModel ProblemModel { get; set; }
        private Problem Problem;
        private IProblemService _problemService;
        public DTOProblemModel DTOProblemModel { get; set; }

        public publishModel(IProblemService problemService)
        {
            _problemService = problemService;
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
            
         
            int Id=_problemService.Publish(DTOProblemModel).Id;
            return Redirect("/ProblemSingle?id="+ Id);
        }
    }

    
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using htmlCssBookStrap.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Servise;

namespace htmlCssBookStrap.Pages
{
    public class ProblemDeleteModel : _LayoutModel
    {
        [BindProperty(SupportsGet =true)]
        public int Id { get; set; }
        private IProblemService _problemService;

        public ProblemDeleteModel(IProblemService problemService)
        {
            _problemService = problemService;
        }

        public override void OnGet()
        {
            _problemService.Delete(Id);
        }

    }
}
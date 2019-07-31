using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using htmlCssBookStrap.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Servise;

namespace htmlCssBookStrap.Pages
{
    public class ProblemModel : _LayoutModel
    {
        private IProblemService _problemService;

        public IList<Problem> problems { get; set; }

        [BindProperty(SupportsGet =true)]
        public int PageIndex { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? AuthorId { get; set; }

        public ProblemModel(IProblemService problemService)
        {
            _problemService = problemService;
        }

        public override void OnGet()
        {
           problems = _problemService.GetAll(AuthorId,PageIndex,2);
        }
    }
}
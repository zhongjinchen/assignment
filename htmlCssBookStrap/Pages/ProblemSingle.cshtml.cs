using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using BLL;
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
        public string Comment { get; set; }
        private IProblemService _problemService;
        public DTOProblemModel DTOProblemModel { get; set; }
        private CommentService _commentService;
        public ProblemSingleModel(IProblemService problemService, CommentService commentService)
        {
            _problemService = problemService;
            _commentService = commentService;
        }
        public override void OnGet()
        {

            //string Id = Request.Query["id"];

            UserToken = _problemService.GetUserToken();


            DTOProblemModel = _problemService.Get(Id);
        }
        public IActionResult OnPost()
        {
            _commentService.Publish(Id,Comment);
            return Redirect($"/problemSingle?Id={Id}");
        }
    }

}
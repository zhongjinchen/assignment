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
        public ProblemModel ProblemModel { get; set; }
        private Problem Problem;
        private IProblemService _problemService;
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
            
            string CurrentUserId = HttpContext.Session.GetString("Id");
            UserModel CurrentUserModel = null;
            if (!string.IsNullOrEmpty(CurrentUserId))
            {
                CurrentUserModel = JsonConvert.DeserializeObject<UserModel>(CurrentUserId);
            }
            int Id=_problemService.Publish(ProblemModel.Title, ProblemModel.Body, CurrentUserModel.Id).Id;
            return Redirect("/ProblemSingle?id="+ Id);
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
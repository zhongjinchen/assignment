using MVCBLL.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Models.MVC17bangModels
{
    public class ProblemModel
    {
        public int Id { get; set; }
        [AllowHtml]
        public string Body { get; set; }
        public Comment Comment { get; set; }
        public IList<Comment> Comments { get; set; }
    }
}
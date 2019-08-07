using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using UI.Controllers;

namespace UI.Models.Register
{
    public class IndexModel
    {
        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Captcha { get; set; }
        public IList<Cites> Cites { get; set; } 
        public string aaa = "aaaaa";
    }
}
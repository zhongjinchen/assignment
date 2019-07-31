using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using BLL.Model;
using htmlCssBookStrap.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Servise;

namespace htmlCssBookStrap.Pages
{
    public class MyMessageModel :_LayoutModel
    {
        public IList<Message> Messages { get; set; }
        private UserService _userService;

        public MyMessageModel(UserService userService)
        {
            _userService = userService;
        }

        public override void OnGet()
        {
            Messages = _userService.GetByMessage();
        }


    }
}
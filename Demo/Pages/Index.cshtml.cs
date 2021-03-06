﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Demo.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        [MaxLength(2,ErrorMessage = "最大长度为2")]
        //[Required(AllowEmptyStrings =true,ErrorMessage = "* 必须填写")]
        [YZrequired]
        [Display(Name ="用户名")]
        //[DisplayFormat(ConvertEmptyStringToNull = false)]
        public string UserName { get; set; }
        [YZOnlyNumber]
        [DataType(DataType.Password)]
        [Display(Name ="密码")]
        public string Password { get; set; }
        public string Remember { get; set; }
        public string student { get; set; }
        public DayOfWeek day { get; set; }
        public Fee YZfee { get; set;}
        //public SelectList NumberList { get; } = new SelectList(new int[] {1,2,3,4 });
        public Stutent Winner { get; set; }
        //public IList<string> Winner { get; set; }
        public IEnumerable<SelectListItem> Stutents { get; set; }
        public void OnGet()
        {
            IList<Stutent> stutents = new List<Stutent>
            {
                new Stutent{Id=1,Name="lc" },
                new Stutent{Id=2,Name="zx" },
                new Stutent{Id=3,Name="wx" },

            };
            Stutents = new SelectList(stutents, "Id", "Name");
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();       //return;
            }
            return RedirectToAction("About");
        }
    }

    public enum Fee
    {
        [Display(Name = "一折")]
        Lower,
        Middle,
        High
    }

    public class Stutent
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class YZrequired : RequiredAttribute
    {
        public override string FormatErrorMessage(string name)
        {
            return $"* {name}必须填写"; 
        }
    }

    public class YZOnlyNumber : RegularExpressionAttribute
    {
        public YZOnlyNumber() : base("[0-9]*")
        {
        }
        public override string FormatErrorMessage(string name)
        {
            return $"{name}必须是数字";
        }
    }
}

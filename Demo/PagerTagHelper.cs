using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo
{
    [HtmlTargetElement("pager",Attributes ="pageIndex,path")]
    public class PagerTagHelper:TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            object pageIndex = context.AllAttributes["pageIndex"].Value;
            object path = context.AllAttributes["path"].Value;
            output.Attributes.Add("href",$"{path}/Page-{pageIndex}");
        }
    }
}

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
 
    [HtmlTargetElement("datetime",Attributes= "asp-showicon"/*,sp-only*/)]
    public class DateTimeTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName= "small";
            if (context.AllAttributes["asp-showicon"] ==null)
            {
                output.Content.SetContent(NowTime());
            }
            else
            {
                if (context.AllAttributes["asp-showicon"].Value.ToString()=="true")
                {
              
                        output.Content.SetHtmlContent($"<span class=\"glyphicon glyphicon-calendar\"></span>{NowTime()}");
                     
                }
                else
                {
                    output.Content.SetContent(NowTime());
                }
                output.Attributes.Clear();

            }
            if (context.AllAttributes["sp-only"] == null)
            {
                
            }
            else
            {
                if (context.AllAttributes["sp-only"].Value.ToString() == "date")
                {

                    output.Content.SetHtmlContent($"{DateTime.Now.Year}年{DateTime.Now.Month}" +
                          $"月{DateTime.Now.Day}日");
                }
                else
                {

                }
                output.Attributes.Clear();

            }


        }
        public string NowTime()
        {
           return $"{DateTime.Now.Year}年{DateTime.Now.Month}" +
                          $"月{DateTime.Now.Day}日{DateTime.Now.Hour}时{DateTime.Now.Minute}分";
        } 
    }
}

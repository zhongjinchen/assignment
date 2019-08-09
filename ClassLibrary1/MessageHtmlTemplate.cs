using System;

namespace GLB
{
    public static class MessageHtmlTemplate
    {
        public static string RegisterSucceed(int id)
        {
            string url = MakeUrl($"/{id}","新手任务");
            return "恭喜你注册成功，看看你的";
        }

        public static string MakeUrl(string url,string text)
        {
            return $"<a href=\"{ url}\">{text}</a>";
        }
    }
}

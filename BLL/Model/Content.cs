using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Content
    {
        public int Id { get; private set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public Content(string title, string body)
        {
            Title = title;
            Body = body;
        }


    }

}

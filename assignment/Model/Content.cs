using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    public class Content
    {
     
        internal string Title { get; }
        internal string Body { get; }

        internal Content( string title, string body)
        {
            Title = title;
            Body = body;
        }


    }

}

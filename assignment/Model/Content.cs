﻿using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    public class Content
    {
        internal int Id { get; }
        internal User Author { get; }
        internal string Title { get; }
        internal string Body { get; }
        internal Comment Comment;
        internal IList<Agree> Agrees;
        internal IList<Disagree> Disagrees;

        internal Content(User author, string title, string body)
        {
            Author = author;
            Title = title;
            Body = body;
            //_date = date;
        }

        internal void Pubilc()
        {
        }
        internal void Agree()
        {
        }
        internal void Disagree()
        {
        }
        
    }

}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace assignment._17ban
{
    public class Content
    {
        public int Id { get; }
        internal User Author { get; }
        internal string Title { get; }
        internal string Body { get; }
        //internal DateTime _date { get; }
        internal Content(User author, string title, string body, DateTime date)
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
        internal void Comment()
        {
        }
    }

}

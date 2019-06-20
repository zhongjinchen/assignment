﻿using System;
using System.Collections.Generic;
using System.Text;

namespace assignment._17ban
{
    class Comment:IPublish<Comment>
    {
        internal Article _article { get; }
        internal User user { get; }
        internal Appraise appraise { get; set; }
        internal string content { get; set; }
        internal IPublish<Comment> publish { get; }
        public Comment(Article article)
        {
            _article = article;
        }

        public void Public(TRepository<Comment> repository)
        {
            repository.Add(this);
        }
    }
}

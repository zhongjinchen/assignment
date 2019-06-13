using System;
using System.Collections.Generic;
using System.Text;

namespace assignment._17ban
{
    class Comment
    {
        internal Article article { get; set; }
        internal Appraise appraise { get; set; }
        internal string content { get; set; }
        public Comment(Publish publish)
        {
            publish.article.comment.Add(this);
        }
    }
}

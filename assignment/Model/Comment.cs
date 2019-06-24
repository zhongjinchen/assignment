using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    public class Comment:IPublish<Comment>
    {
        public Article _article { get; }
        public User user { get; }
        public Appraise appraise { get;}
        public string content { get; }
        public IPublish<Comment> publish { get; }
        public Comment(Article article)
        {
            _article = article;
        }
        public void Add()
        {
            _article.comment.Add(this);
        }
        public void Public()
        {
            
        }
    }
}

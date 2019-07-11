using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Comment:IPublish
    {
        public int Id { get; }
        public Article Article { get; }
        public User User { get; }
        public Appraise Appraise { get; }
        public string Body { get; }

        public Comment(Article article)
        {
            Article = article;
        }
        public void Add()
        {
            Article.Comments.Add(this);
        }
        public void Publish()
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace assignment._17ban
{
    public class Article : IPublish<XEArticleRepository>,IPublish<ArticleRepository>
    {
  
        internal List<Comment> comment { get; set; }
        internal Appraise appraise { get; set; }
        internal List<KeyWord> keyWords { get; set; }
        public Content Content;
        public Article(Content content)
        {
            Content = content;
        }
        public void Public(XEArticleRepository repository)
        {
            repository.Add(this);
        }

        public void Public(ArticleRepository repository)
        {
            repository.Add(this);
        }
    }
}

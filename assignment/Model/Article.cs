using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    public class Article : IPublish<XArticleRepository>,IPublish<MArticleRepository>
    {
  
        internal List<Comment> comment { get; set; }
        internal Appraise appraise { get; set; }
        internal List<KeyWord> keyWords { get; set; }
        public Content Content;
        public Article(Content content)
        {
            Content = content;
        }
        public void Public()
        {
            
        }

        public void Public(MArticleRepository repository)
        {
            repository.Add(this);
        }
    }
}

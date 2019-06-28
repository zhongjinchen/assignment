using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    public class Article : IPublish<Article>
    {
  
        public List<Comment> comment { get; }
        //public Appraise<Article> appraise { get; }
       
        public List<KeyWord> KeyWords { get; }
        public Content Content;
        public Article(Content content,List<KeyWord> keyWords )
        {
            Content = content;
            KeyWords = keyWords;
        }
        public void Public()
        {
            
        }

    }
}

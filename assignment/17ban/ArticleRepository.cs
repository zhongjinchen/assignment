using System;
using System.Collections.Generic;
using System.Text;

namespace assignment._17ban
{
    class ArticleRepository : IArticleRepository
    {
        private IList<Article> _articles { get; set; }
        public  IList<Article> Get()
        {
            return _articles;
        }
        public static IList<Article> GetBy()
        {
            return new List<Article>(); 
        }
        public void Add(Article article)
        {
            _articles.Add(article);
        }
    }
}

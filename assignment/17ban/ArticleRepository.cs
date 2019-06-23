using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace assignment._17ban
{
    public class ArticleRepository : IArticleRepository
    {
        private static IList<Article> Trepository;
        public IList<Article> Get()
        {
            return Trepository;
        }
        public void Add(Article article)
        {
            if (Trepository == null)
            {
                Trepository = new List<Article>();
            }
            else
            {
               
            }
            Trepository.Add(article);
      
        }
        public Article GetByAuthor(string Author)
        {
            return ;
        }
    }
}

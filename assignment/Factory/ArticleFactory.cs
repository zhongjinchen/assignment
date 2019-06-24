
using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    public class ArticleFactory
    {
        private IRepository<Article> _repository;
        public ArticleFactory(IRepository<Article> repository)
        {
            _repository = repository;
        }
        public static void inti()
        {
            //#if XML
            //            ArticleFactory articleFactory = new ArticleFactory(new XArticleRepository());
            //#elif Memory
            //            ArticleFactory articleFactory = new ArticleFactory(new MArticleRepository());
            //#endif
            ArticleFactory articleFactory = new ArticleFactory(new XArticleRepository());
            articleFactory.Make();
        }
        public void Make()
        {
            Article article = new Article(new Content(new User(1,"",1234), "", ""),new List<KeyWord>());
            article.Public();
            IRepository<Article> repository = new XArticleRepository();
            repository.Add(article);
        }
    }
}


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
        public static void init()
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
            //User lc = UserRepoistory.Get(/*id*/1);
            //Article article = new Article(new Content( "", ""),new Message(),new List<KeyWord>());
            //article.Publish();
            //_repository = new XArticleRepository();
            //_repository.Add(article);
        }
    }
}

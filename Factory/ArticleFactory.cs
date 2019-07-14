using BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
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
        public void Make(/*Article article*/)
        {
            //User lc = UserRepoistory.Get(/*id*/1);
            ////article应该作为一个参数传入，而不是在方法里面自己生成
            //Article article = new Article(new Content("", ""), new Message(), new List<KeyWord>());
            //article.Publish();
            //_repository.Add(article);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace BLL
{
    public class MArticleRepository : IRepository<Article>
    {
        private static IList<Article> Repository;
        public IList<Article> Get()
        {
            return Repository;
        }
        public void Add(Article article)
        {
            //只考虑“Trepository == null”的情况
            if (Repository == null)
            {
                Repository = new List<Article>();
            }

            Repository.Add(article);
        }

        public Article GetBy(int id)
        {
            var article= Repository.Where(w=>w.Id==id).Single();
            return article;
        }

        public void Delete(Article model)
        {
            Repository.Remove(model);
        }
    }
}

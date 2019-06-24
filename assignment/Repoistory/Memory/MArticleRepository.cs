using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace assignment
{
    public class MArticleRepository : IRepository<Article>
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

        public Article GetById(int Id)
        {
            return ;
        }

        public Article Load()
        {
            throw new NotImplementedException();
        }
    }
}

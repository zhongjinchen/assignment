using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace assignment._17ban
{
    public class ArticleRepository : IRepository
    {
        private static XElement Trepository;
        public XElement Get()
        {
            return Trepository;
        }
        public void Add(Article article, DateTime publishDate)
        {
            if (Trepository == null)
            {
                Trepository = new XElement("articles");

            }
            else
            {
               
            }
            Trepository.Add(
              new XElement(
                "article",
                new XElement(
                  "user",
                  new XElement("id", article.Content.Author.Id),
                  new XElement("name", "id", article.Content.Author.Name),
                  new XElement("password", article.Content.Author.Password)
                ),
                new XAttribute("isDraft", "true"),
                new XElement("id", article.Content.Id),
                new XElement("title", article.Content.Title),
                new XElement("publishDate", publishDate),
                new XElement("comments")
              )
            );
        }
        public IList<Article> GetBy(string title)
        {
            return new List<Article>();
        }
    }
}

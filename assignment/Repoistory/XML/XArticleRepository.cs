using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.IO;

namespace assignment
{
    public class XArticleRepository:XRepository<Article>
    {
        private const string path = @"C:\17bang\repoistory\Articl";
        private static IList<Article> Trepository;
        public override IList<Article> Get()
        {
            XElement articles = XElement.Load(path);
            IList<XElement> XArticles =(IList<XElement>)articles.Descendants();
            IList<Article> result = new List<Article>();
            foreach (var item in XArticles)
            {
                result.Add(MapIntoModel(item));
                return result;
            }
            //    XElement New = MapIntoXml(article);
            //    old.Add(New);
            return Trepository;
        }
        public override void Add(Article article)
        {
            if (File.Exists(path))
            {
           
            }
            else
            {
                File.CreateText(path);
            }
            XElement old = XElement.Load(path);
            XElement New = MapIntoXml(article);
            old.Add(New);
        }
        public void Save()
        {

        }
        public IList<Article> GetBy(string title)
        {
            return new List<Article>();
        }

        public Article Load()
        {
            throw new NotImplementedException();
        }
        public Article MapIntoModel(XElement element )
        {
            int UserId = Convert.ToInt32(element.Element("user").Element("id").Value);
            string name = element.Element("user").Element("name").Value.ToString();
            int password= Convert.ToInt32(element.Element("user").Element("password").Value);
            User user = new User(UserId, name, password);
            string title = element.Element("title").Value.ToString();
            string body= element.Element("body").Value.ToString();

            return new Article(new Content(user,title,body));
        }
        public XElement MapIntoXml(Article article)
        {


            XElement element=new XElement(
              "article",
              new XElement(
                "user",
                new XElement("id", article.Content.Author.Id),
                new XElement("name", article.Content.Author.Name),
                new XElement("password", article.Content.Author.Password)
              ),
              new XAttribute("isDraft", "true"),
              new XElement("id", article.Content.Id),
              new XElement("title", article.Content.Title),
              new XElement("publishDate", DateTime.Now),
              new XElement("comments")
            );

            return element;
        }
    }
}

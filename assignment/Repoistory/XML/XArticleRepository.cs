using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.IO;

namespace assignment
{
    public class XArticleRepository:Repository<Article>
    {
        private const string path = @"C:\17bang\repoistory\Articl";
    
        private XElement articles;

        public override IList<Article> Get()
        {
            articles = XElement.Load(path);
            IList<XElement> XArticles =(IList<XElement>)articles.Descendants();
            IList<Article> result = new List<Article>();
            foreach (var item in XArticles)
            {
                result.Add(MapIntoModel(item));
                
            }
            return result;
        }

        public override void Add(Article article)
        {
            if (File.Exists(path))
            {
            }
            else
            {
                //File.CreateText(path);
                XElement element = new XElement("articles");
                Save();
            }
            articles = XElement.Load(path);
            XElement New = MapIntoXml(article);
            articles.Add(New);
            Save();
        }

        public void Save()
        {
            articles.Save(path);
        }

        public Article GetById(int Id)
        {
            return new Article();
        }

        //XElement转换成Article方法
        public Article MapIntoModel(XElement element )
        {
            int UserId = Convert.ToInt32(element.Element("user").Element("id").Value);
            string name = element.Element("user").Element("name").Value.ToString();
            int password= Convert.ToInt32(element.Element("user").Element("password").Value);
            User user = new User(UserId, name, password);
            string title = element.Element("title").Value.ToString();
            string body= element.Element("body").Value.ToString();

            return new Article(new Content(user,title,body), new List<KeyWord>());
        }

        //Article转换成XElement方法
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

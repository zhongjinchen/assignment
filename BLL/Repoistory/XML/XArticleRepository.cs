using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.IO;
using System.Linq;

namespace BLL
{
    public class XArticleRepository:XRepository<Article>
    {
        private const string _path = @"C:\17bang\repoistory\Articl";
    
        private XElement _article;

        public override IList<Article> Get()
        {
            _article = XElement.Load(_path);
            IList<XElement> XArticles = _article.Elements().ToList();
            IList<Article> result = new List<Article>();
            foreach (var item in XArticles)
            {
                result.Add(MapIntoModel(item));
                
            }
            return result;
        }

        public override void Add(Article article)
        {
            //只考虑“File.Exists(_path)==false”的情况

            if (File.Exists(_path)==false)
            {
                //File.CreateText(path);
                XElement element = new XElement("articles");
                Save();
            }

            _article = XElement.Load(_path);
            XElement New = MapIntoXml(article);
            _article.Add(New);
            Save();
        }

        public override void Delete(Article model)
        {
            _article = XElement.Load(_path);
            var article = _article.Elements("article").Where(w => w.Element("id").Value == 12.ToString());
            article.Remove();
            Save();
        }

        public override Article GetBy(int id)
        {
            var article =Get().Where(w=>w.Id==id).Single();
            return article;
        }

        public void Save()
        {
            _article.Save(_path);
        }

        //XElement转换成Article方法
        public Article MapIntoModel(XElement element )
        {
            int Id = Convert.ToInt32(element.Element("id").Value);

            int UserId = Convert.ToInt32(element.Element("user").Element("id").Value);
            string name = element.Element("user").Element("name").Value.ToString();
            string password= element.Element("user").Element("password").Value;
            User user = new User(name, password);
            string title = element.Element("title").Value.ToString();
            string body= element.Element("body").Value.ToString();

            return new Article();
        }

        //Article转换成XElement方法
        public XElement MapIntoXml(Article article)
        {


            XElement element=new XElement(
              "article",
              new XElement(
                "user",
                new XElement("id", article.User.Id),
                new XElement("name", article.User.Name),
                new XElement("password", article.User.Password)
              ),
              new XAttribute("isDraft", "true"),
              new XElement("id", article.User.Id),
              new XElement("title", article.Title),
              new XElement("publishDate", DateTime.Now),
              new XElement("comments")
            );

            return element;
        }
    }
}

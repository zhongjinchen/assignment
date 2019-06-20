using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace assignment
{
    class AddXElement
    {
        internal void addArticle(XElement element, int userId, string name,
           int password, int articleId, string title, int authorId, string publishDate)
        {
            XElement article = new XElement(
              "article",
              new XElement(
                "user",
                new XElement("id", userId),
                new XElement("name", name),
                new XElement("password", password)
              ),
              new XAttribute("isDraft", "true"),
              new XElement("id", articleId),
              new XElement("title", title),
              new XElement("authorId", authorId),
              new XElement("publishDate", publishDate), new XElement("comments")
                      
           );
            element.Add(article);
        }
        internal XElement addCommnt()
        {
            XElement comment = new XElement(
                       "comment", new XAttribute("recommend", "true"),
                       new XElement("id", 14),
                       new XElement("body", "不错，赞!"),
                       new XElement("authorId", 2)
                       );
            
            return comment;
        }
    }
}

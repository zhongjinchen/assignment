using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace assignment
{
    class XEProblemRepository:Repository<Problem>
    {
        private const string path = @"C:\17bang\repoistory\Articl";

        private XElement problems;

        public override IList<Problem> Get()
        {
            problems = XElement.Load(path);
            IList<XElement> XProblems = (IList<XElement>)problems.Descendants();
            IList<Problem> result = new List<Problem>();
            foreach (var item in XProblems)
            {
                result.Add(MapIntoModel(item));

            }
            return result;
        }

        public override void Add(Problem problem)
        {
            if (File.Exists(path))
            {
            }
            else
            {
                //File.CreateText(path);
                XElement element = new XElement("problems");
                Save();
            }
            problems = XElement.Load(path);
            XElement New = MapIntoXml(problem);
            problems.Add(New);
            Save();
        }

        public void Save()
        {
            problems.Save(path);
        }

        public Problem GetById(int Id)
        {
            return new Problem();
        }

        //XElement转换成Problem方法
        public Problem MapIntoModel(XElement element)
        {
            int UserId = Convert.ToInt32(element.Element("user").Element("id").Value);
            string name = element.Element("user").Element("name").Value.ToString();
            int password = Convert.ToInt32(element.Element("user").Element("password").Value);
            User user = new User(UserId, name, password);
            string title = element.Element("title").Value.ToString();
            string body = element.Element("body").Value.ToString();

            return new Problem(new Content(user, title, body),new List<KeyWord>());
        }

        //Problem转换成XElement方法
        public XElement MapIntoXml(Problem problem)
        {


            XElement element = new XElement(
              "problem",
              new XElement(
                "user",
                new XElement("id", problem.Content.Author.Id),
                new XElement("name", problem.Content.Author.Name),
                new XElement("password", problem.Content.Author.Password)
              ),
              new XAttribute("isDraft", "true"),
              new XElement("id", problem.Content.Id),
              new XElement("title", problem.Content.Title),
              new XElement("publishDate", DateTime.Now),
              new XElement("comments")
            );

            return element;
        }

    }

}

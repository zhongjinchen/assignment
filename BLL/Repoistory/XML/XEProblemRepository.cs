using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace BLL
{
    class XEProblemRepository:XRepository<Problem>
    {
        private const string _path = @"C:\17bang\repoistory\Articl";

        private XElement _problems;

        public override IList<Problem> Get()
        {
            _problems = XElement.Load(_path);
            IList<XElement> XProblems = (IList<XElement>)_problems.Descendants();
            IList<Problem> result = new List<Problem>();
            foreach (var item in XProblems)
            {
                result.Add(MapIntoModel(item));

            }
            return result;
        }

        public override void Add(Problem problem)
        {
            if (File.Exists(_path))
            {
            }
            else
            {
                //File.CreateText(path);
                XElement element = new XElement("problems");
                Save();
            }
            _problems = XElement.Load(_path);
            XElement New = MapIntoXml(problem);
            _problems.Add(New);
            Save();
        }

        public void Save()
        {
            _problems.Save(_path);
        }

        public Problem GetById(int Id)
        {
            //return new Problem();
            throw new NotImplementedException();
        }

        //XElement转换成Problem方法
        public Problem MapIntoModel(XElement element)
        {
            int UserId = Convert.ToInt32(element.Element("user").Element("id").Value);
            string name = element.Element("user").Element("name").Value.ToString();
            string password = element.Element("user").Element("password").Value;
            User user = new User(name, password);
            string title = element.Element("title").Value.ToString();
            string body = element.Element("body").Value.ToString();

            //return new Problem(new Content( title, body),new Message(),new List<KeyWord>());
            return null;
        }

        //Problem转换成XElement方法
        public XElement MapIntoXml(Problem problem)
        {


            XElement element = new XElement(
              "problem",
              new XElement(
                "user",
                new XElement("id", problem.User.Id),
                new XElement("name", problem.User.Name),
                new XElement("password", problem.User.Password)
              ),
              new XAttribute("isDraft", "true"),
              new XElement("id", problem.Id),
              new XElement("title", problem.Title),
              new XElement("publishDate", DateTime.Now),
              new XElement("comments")
            );

            return element;
        }

    }

}

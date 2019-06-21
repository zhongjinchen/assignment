using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace assignment._17ban
{
    class XEProblemRepository
    {
        private static XElement Trepository;
        public XElement Get()
        {
            return Trepository;
        }
        public void Add(Problem problem)
        {
            if (Trepository != null)
            {
                Trepository.Add(problem);
            }
            else
            {
                Trepository = new XElement("problems");
                Trepository.Add(problem);
            }
        }
        public IList<Problem> GetBy(string title)
        {
            return new List<Problem>();
        }
    }
   
}

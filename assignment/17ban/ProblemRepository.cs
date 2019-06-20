using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace assignment._17ban
{
    class ProblemRepository : IRepository
    {
        private static XElement Trepository;
        public XElement Get()
        {
            return Trepository;
        }
        public void Add(Problem thing)
        {
            if (Trepository != null)
            {
                Trepository.Add(thing);
            }
            else
            {
                Trepository = new XElement("problems");
                Trepository.Add(thing);
            }
        }
        public IList<Problem> GetBy(string title)
        {
            return new List<Problem>();
        }
    }
}

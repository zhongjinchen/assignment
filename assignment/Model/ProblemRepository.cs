using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace assignment
{
    class ProblemRepository : IRepository<Problem>
    {
        private static IList<Problem> Trepository;
        public IList<Problem> Get()
        {
            return Trepository;
        }
        public void Add(Problem problem)
        {
            if (Trepository == null)
            {
                Trepository = new List<Problem>();
            }
            else
            {

            }
            Trepository.Add(problem);
        }
        public IList<Problem> GetBy(string title)
        {
            return new List<Problem>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace assignment
{
    class ProblemRepository : Repository<Problem>
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

        public Problem GetById()
        {
            throw new NotImplementedException();
        }

        public void Delete(Problem model)
        {
            throw new NotImplementedException();
        }
    }
}

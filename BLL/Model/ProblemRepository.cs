using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace BLL
{
    class ProblemRepository : Repository<Problem>
    {
        private static IList<Problem> Repository;
        public IList<Problem> Get()
        {
            return Repository;
        }
        public void Add(Problem problem)
        {
            if (Repository == null)
            {
                Repository = new List<Problem>();
            }
            else
            {

            }
            Repository.Add(problem);
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

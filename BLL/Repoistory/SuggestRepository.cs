using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repoistory
{
    public class SuggestRepository
    {
        private SQLContext _sqlContext;
        public SuggestRepository()
        {
            _sqlContext = new SQLContext();
        }

        public Suggest Save(Suggest suggest)
        {
            using (_sqlContext)
            {
                _sqlContext._suggests.Add(suggest);
                _sqlContext.SaveChanges();
            }

            return suggest;
        }
    }
}

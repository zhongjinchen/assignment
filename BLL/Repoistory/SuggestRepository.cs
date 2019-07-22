using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Repoistory
{
    public class SuggestRepository :Repository<Suggest>
    {
        private SQLContext _sqlContext;
        public SuggestRepository()
        {
            _sqlContext = new SQLContext();
        }

    }
}

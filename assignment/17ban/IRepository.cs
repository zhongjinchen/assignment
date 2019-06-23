using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace assignment._17ban
{
    interface IRepository<T>
    {
        List<T> Get();

    }
    interface IArticleRepository : IRepository<Article>
    {

    }
}

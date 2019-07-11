using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class KeyWord
    {
        public int Id { get; }
        internal string Name { get; set; }
        internal IList<Article> Articles { get; set; }
    }
}

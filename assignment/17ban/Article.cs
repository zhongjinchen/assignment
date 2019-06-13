using System;
using System.Collections.Generic;
using System.Text;

namespace assignment._17ban
{
    class Article : Common
    {
        internal List<Comment> comment { get; set; }
        internal Appraise appraise { get; set; }
        internal List<KeyWord> keyWords { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    class Problem : IPublish<Article>
    {
        public int Reward { get; }
        public Content Content{ get;}
        public List<KeyWord> KeyWords { get; }
        public int AgreeCount;
        public int DisagreeCount;
        public Problem(Content content, List<KeyWord> keyWords)
        {
            Content = content;
            KeyWords = keyWords;
        }

        public void Public()
        {
            throw new NotImplementedException();
        }
    }
}

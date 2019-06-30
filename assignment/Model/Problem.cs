using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    class Problem : IPublish
    {
        public int Reward { get; }
        public Content Content{ get;}
        public IList<KeyWord> KeyWords { get; }
        public int AgreeCount;
        public int DisagreeCount;
        public Problem(Content content, List<KeyWord> keyWords)
        {
            Content = content;
            KeyWords = keyWords;
        }

        public void Publish()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    public class Suggest : IPublish
    {
        private Content Content;
        public int AgreeCount;
        public int DisagreeCount;
        public Suggest(Content content)
        {
            Content = content;
        }


        public void Publish()
        {
            throw new NotImplementedException();
        }
    }
}

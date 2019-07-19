using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Suggest : IPublish
    {
        public Message Message;
        private Content Content;
        public int AgreeCount;
        public int DisagreeCount;
        public DateTime PublishedTime { get; private set; }
        public Suggest(Content content)
        {
            Content = content;
        }


        public void Publish()
        {
            PublishedTime =DateTime.Now ;
        }
    }
}

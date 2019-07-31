
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Suggest : Entity,IPublish
    {

        //public Message Message { get; set; }
        //public Content Content { get; set; }
        public virtual User Author { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int AgreeCount { get; set; }
        public int DisagreeCount { get; set; }
        public DateTime PublishedTime { get; private set; }
        //public Suggest(Content content,Message message)
        //{
        //    Message = message;
        //    Content = content;
        //}
        public Suggest()
        {
      
        }

        public void Publish()
        {
            PublishedTime =DateTime.Now ;
        }
    }
}

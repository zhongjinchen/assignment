using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Problem : Entity, IPublish
    {
        public int Reward { get; set; }
        public Message Message { get; set; }
        public Content Content { get; set; }
        //public List<Comment> Comments { get; set; }
        //public Appraise appraise { get; set; }
        //public List<KeyWord> KeyWords { get; set; }
        public Problem()
        {

        }
        public Problem(Content content, Message message, List<KeyWord> keyWords)
        {
            Content = content;
            Message = message;
            //KeyWords = keyWords;
        }

        public void Publish()
        {
            
        }
    }
}

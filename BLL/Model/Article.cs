using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Article : IPublish
    {
        public Message Message { get; }
        public Content Content { get; }
        public List<Comment> Comments { get; }
        public Appraise appraise { get; }
        public List<KeyWord> KeyWords { get; }

        public Article(Content content, Message message, List<KeyWord> keyWords )
        {
            Content = content;
            Message = message;
            KeyWords = keyWords;
        }

        public void Publish()
        {
            
        }

    }
}

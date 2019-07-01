﻿using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    class Problem : IPublish
    {
        public int Reward { get; }
        public Message Message { get; }
        public Content Content { get; }
        public List<Comment> Comments { get; }
        public Appraise appraise { get; }
        public List<KeyWord> KeyWords { get; }
        public Problem(Content content, Message message, List<KeyWord> keyWords)
        {
            Content = content;
            Message = message;
            KeyWords = keyWords;
        }

        public void Publish()
        {
            throw new NotImplementedException();
        }
    }
}

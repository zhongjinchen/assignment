using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Model
{
    public class Message:Entity
    {

        public virtual User Receiver { get; set; }
        public string Content { get; set; }
        public string CommentTime { get; set; }

        public void Send()
        {
            Receiver.Messages = Receiver.Messages ?? new List<Message>();
            Receiver.Messages.Add(this);
        }
    }
}

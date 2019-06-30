using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    public class Message
    {
        internal int Id { get; }
        internal User Author { get; }
        public Message(int id, User author)
        {
            Id = id;
            Author = author; 
        }
    }
}

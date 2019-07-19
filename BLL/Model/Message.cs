using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Message
    {
        public int Id { get;private set; }
        public User Author { get; set; }
        public Message(User author)
        {
            
            Author = author; 
        }
    }
}

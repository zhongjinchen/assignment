using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Message: Entity
    {
        
        public User Author { get; set; }
        public Message(User author)
        {
            
            Author = author; 
        }
    }
}

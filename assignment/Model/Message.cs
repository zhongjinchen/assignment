﻿using System;
using System.Collections.Generic;
using System.Text;

namespace assignment
{
    public class Message
    {
        public int Id { get; }
        public User Author { get; }
        public Message(int id, User author)
        {
            Id = id;
            Author = author; 
        }
    }
}

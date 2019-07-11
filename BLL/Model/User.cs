using assignment;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class User
    {
        public int Id;
        public string Name { get; }
        public int Password;
        public Token token { get; }
        public User(int id,string name,int password)
        {
            Id = id;
            Name = name;
            Password = password;
        }

    }
}

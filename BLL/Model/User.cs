using assignment;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Token token { get; }

        public User()
        {

        }

        public User(string name,string password)
        {
           
            Name = name;
            Password = password;
        }

        public void Register()
        {

        }
    }
}

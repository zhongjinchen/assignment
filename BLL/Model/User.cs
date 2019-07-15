using assignment;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BLL
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public User InvitedBy { get; set; }


        public Token token { get; }
        private const string _salt = "yzlc";
        public User()
        {

        }

        public User(string name, string password)
        {

            Name = name;
            Password = password;
        }

        public void Register()
        {
            if (InvitedBy != null)
            {

            }
            using (MD5 md5Hash = MD5.Create())
            {
                Password = GetMd5Hash(md5Hash, Password + _salt);
            }
        }

        private string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                stringBuilder.Append(data[i].ToString("x2"));
            }
            return stringBuilder.ToString();
        }



    }
}

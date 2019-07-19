using assignment;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;
using System.Text;

namespace BLL
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string Password { get; set; }
        [NotMapped]
        public string ConfirmPassword { get; set; }

        public User InvitedBy { get; set; }


        public Token token { get; }

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

            Password = GetMd5Hash(Password);

        }

        public static string GetMd5Hash(string input)
        {
            const string _salt = "yzlc";
            using (MD5 md5Hash = MD5.Create())
            {
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input + _salt));
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    stringBuilder.Append(data[i].ToString("x2"));
                }
                return stringBuilder.ToString();
            }
        }



    }
}

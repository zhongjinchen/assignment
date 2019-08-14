using MVCBLL.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace MVCBLL.Entitis
{
    public class User : Entity
    {
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public virtual Email Email { get; set; }

        public virtual User InvitedBy { get; set; }

        public int AntiForgeryToken { get; set; }

        public virtual IList<Message> Messages { get; set; }

        public void Register()
        {
            if (InvitedBy != null)
            {

            }

            Password = GetMd5Hash(Password);
            AntiForgeryToken = new Random().Next();

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

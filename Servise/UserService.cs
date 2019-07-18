using BLL;
using System;
using System.Net.Mail;

namespace Servise
{
    public class UserService
    {
        private UserRepoistory _userRepoistory;
        public UserService()
        {
            _userRepoistory = new UserRepoistory();
        }
        public void Register(string name, string password)
        {
            User user = new User(name, password);
            user.Register();
            _userRepoistory.Save(user);
        }

        public bool HasExist(string userName)
        {
            return _userRepoistory.GetByName(userName) != null;
        }

        public UserMode GetById(int Id)
        {
            User user=_userRepoistory.GetById(Id);
            return MapFrom(user);
        }

        public void SendValidationEmail(string emailAddress,string ValidationUrlFormat)
        {
            Email email = new Email { Address = emailAddress };
            email.MakeValidationCode();

            _userRepoistory.Save(email);

            string VaildationUrl = string.Format(ValidationUrlFormat, email.ValidationCode, email.Id);

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("2430156404@qq.com");
            mail.To.Add(emailAddress);
            mail.Subject = "一起帮邮件";
            mail.Body = VaildationUrl;

            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);
        }

        public UserMode GetName(string userName)
        {
            User user = _userRepoistory.GetByName(userName);
            return MapFrom(user);
        }

        private UserMode MapFrom(User user)
        {
            if (user == null)
            {
                return null;
            }
            else
            {
                UserMode userMode = new UserMode
                {
                    Id = user.Id,
                    Name = user.Name,
                    MD5Password = user.Password
                };
                return userMode;
            }
        }

        public bool PasswordCorrect(string rawpassword,string MD5Password)
        {
            return User.GetMd5Hash(rawpassword)==MD5Password;
        }

      

        public bool ValidationEmail(int id, string code)
        {
            Email email=_userRepoistory.GetEmailById(id);
            email.Validate();
            _userRepoistory.Flush();
            return email.ValidationCode == code;
        }
    }

    public class UserMode
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MD5Password { get; set; }
    }
}

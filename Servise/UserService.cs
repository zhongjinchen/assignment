using BLL;
using BLL.Model;
using BLL.Repoistory;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace Servise
{
    public class UserService:BaseService
    {
        private UserRepository _userRepository;
        private EmailRepository _emailRepository;

        public UserService(UserRepository userRepository, EmailRepository emailRepository, 
               IHttpContextAccessor accessor) :base(accessor)
        {
            _userRepository = userRepository;
            _emailRepository = emailRepository;
        }
        public User Register(string name, string password, string email)
        {

            User user = new User(name, password)
            {
                Email = new Email
                {
                    Address = email
                }
            };

            user.Register();

            _userRepository.Save(user);

            return user;
        }

        public IList<Message> GetByMessage()
        {
           return _userRepository.GetById(CurrentUser.Id).SingleOrDefault().Messages;
        }

        public bool HasExist(string userName)
        {
            return _userRepository.GetByName(userName) != null;
        }

        public UserModel GetById(int Id)
        {
            User user = _userRepository.GetById(Id).SingleOrDefault();
            return MapFrom(user);
        }

        public bool HasExistEmail(string email)
        {
            return _userRepository.GetByEmail(email) != null;
        }

        public void SendValidationEmail(string emailAddress, string ValidationUrlFormat)
        {
            Email email = new Email { Address = emailAddress };
            email.MakeValidationCode();

            _emailRepository.Save(email);

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

        public void ResetPassword(string password,int UserId)
        {
            _userRepository.ResetPassword(password, UserId);
        }

        public UserModel GetName(string userName)
        {
            User user = _userRepository.GetByName(userName).SingleOrDefault();
            return MapFrom(user);
        }

        private UserModel MapFrom(User user)
        {
            if (user == null)
            {
                return null;
            }
            else
            {
                UserModel userMode = new UserModel
                {
                    UserModelId = user.Id,
                    Name = user.Name,
                    MD5Password = user.Password
                };
                return userMode;
            }
        }

        public bool PasswordCorrect(string rawpassword, string MD5Password)
        {
            return User.GetMd5Hash(rawpassword) == MD5Password;
        }



        public bool ValidationEmail(int id, string code)
        {
            Email email = _userRepository.GetEmailById(id);
            email.Validate();
            _userRepository.Flush();
            return email.ValidationCode == code;
        }
    }

    public class UserModel
    {
        public int UserModelId { get; set; }
        public string Name { get; set; }
        public string MD5Password { get; set; }
    }
}

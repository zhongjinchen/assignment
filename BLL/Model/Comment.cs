using BLL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Comment: Entity, IPublish
    {
       
        public virtual Problem Problem{ get; set; }
        public virtual User User { get; set; }
        //public Appraise Appraise { get; }
        public string Body { get; set; }


        public Comment()
        {
         
        }

        public void Add()
        {
            Problem.Comments.Add(this);
        }

        public void Publish()
        {
            //Problem.Comments = Problem.Comments ?? new List<Comment>();
            //Problem.Comments.Add(this);

            Message message = new Message
            {
                Receiver = Problem.User,
                Content = Body,
                CommentTime = $"{DateTime.Now.Year}年{DateTime.Now.Month}月{DateTime.Now.Day}" +
            $"日{DateTime.Now.Hour}时{DateTime.Now.Minute}分"
            };

            message.Send();
        }
    }
}

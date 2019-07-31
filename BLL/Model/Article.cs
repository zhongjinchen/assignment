using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Article : Entity, IPublish
    {
        public User User { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public List<Comment> Comments { get; }
        //public Appraise appraise { get; }
        //public List<KeyWord> KeyWords { get; }

        public Article()
        {

            
        }

        public void Publish()
        {
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Problem : Entity, IPublish
    {
        public int Reward { get; set; }
        public virtual User User { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Date { get; set; }
        public virtual List<Comment> Comments { get; set; }
        //public Appraise appraise { get; set; }
        //public List<KeyWord> KeyWords { get; set; }
        public Problem()
        {

        }
        public Problem(User Author,string Title,string Body , List<KeyWord> keyWords)
        {
        
        }

        public void Publish()
        {
            Date = $"{DateTime.Now.Year}年{DateTime.Now.Month}月{DateTime.Now.Day}" +
                $"日{DateTime.Now.Hour}时{DateTime.Now.Minute}分";
            
        }
    }
}

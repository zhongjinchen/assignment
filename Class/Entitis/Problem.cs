using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBLL.Entitis
{
    public class Problem : Entity
    {
        public int Reward { get; set; }
        public virtual User User { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Date { get; set; }
        public virtual List<Comment> Comments { get; set; }
        //public Appraise appraise { get; set; }
        //public List<KeyWord> KeyWords { get; set; }
    }
}

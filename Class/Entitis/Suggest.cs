using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBLL.Entitis
{
    public class Suggest : Entity
    {

        //public Message Message { get; set; }
        //public Content Content { get; set; }
        public virtual User Author { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int AgreeCount { get; set; }
        public int DisagreeCount { get; set; }
        public DateTime PublishedTime { get; private set; }
    }
}

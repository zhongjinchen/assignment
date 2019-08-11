using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBLL.Entitis
{
    public class Message
    {
        public virtual User Receiver { get; set; }
        public string Content { get; set; }
        public string CommentTime { get; set; }
    }
}

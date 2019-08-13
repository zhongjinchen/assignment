using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBLL.Entitis
{
    public class Comment : Entity
    {
        public virtual Problem Problem { get; set; }
        public virtual User User { get; set; }
        //public Appraise Appraise { get; }
        public string Body { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBLL.Entitis
{
    public class Appraise : Entity
    {
        internal IList<Agree> Agrees;
        internal IList<Disagree> Disagrees;
    }
}

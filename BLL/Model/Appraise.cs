
using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    public class Appraise: Entity
    {
        internal IList<Agree> Agrees;
        internal IList<Disagree> Disagrees;
        internal void Agree()
        {
            Agrees.Add(new Agree());
        }
        internal void Disagree()
        {
            Disagrees.Add(new Disagree());
        }
    }

}

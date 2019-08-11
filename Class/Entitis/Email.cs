using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBLL.Entitis
{
    public class Email
    {
        public string Address { get; set; }
        public string ValidationCode { get; set; }
        public DateTime? EmailHasValidated { get; set; }
    }
}

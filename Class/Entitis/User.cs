using MVCBLL.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVCBLL.Entitis
{
    public class User : Entity
    {
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public virtual Email Email { get; set; }

        public virtual User InvitedBy { get; set; }

        public int AntiForgeryToken { get; set; }

        public virtual IList<Message> Messages { get; set; }
    }
}

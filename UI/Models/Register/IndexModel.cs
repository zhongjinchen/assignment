﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UI.Models.Register
{
    public class IndexModel
    {
        [Required]
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
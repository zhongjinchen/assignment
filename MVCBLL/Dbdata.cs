using Microsoft.EntityFrameworkCore;
using System;


namespace MVCBLL
{
    public class Dbdata:DbContext
    {
        public Dbdata():base("MVC17bang")
        {

        }
    }
}

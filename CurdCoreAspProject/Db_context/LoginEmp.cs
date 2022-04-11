using System;
using System.Collections.Generic;

#nullable disable

namespace CurdCoreAspProject.Db_context
{
    public partial class LoginEmp
    {
        public int Id { get; set; }
        public string Ename { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

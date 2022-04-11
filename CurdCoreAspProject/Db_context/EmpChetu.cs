using System;
using System.Collections.Generic;

#nullable disable

namespace CurdCoreAspProject.Db_context
{
    public partial class EmpChetu
    {
        public int Eid { get; set; }
        public string Ename { get; set; }
        public string Eemail { get; set; }
        public string City { get; set; }
        public int? Salary { get; set; }
    }
}

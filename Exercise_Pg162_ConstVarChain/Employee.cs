using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Pg162_ConstVarChain
{
    public class Employee
    {
        public Employee(string name) : this(name, "Software Development")
        {
        }
        public Employee(string name, string departmentName)
        {
            Name = name;
            Department = departmentName;

        }
        public string Name { get; set; }
        public string Department { get; set; }
    }
}

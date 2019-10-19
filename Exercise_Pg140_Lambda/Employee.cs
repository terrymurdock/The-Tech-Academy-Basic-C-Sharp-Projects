using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Pg140_Lambda
{
    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int iD { get; set; }

        public override string ToString()
        {
            return "ID: " + iD + " Name: " + firstName + " " + lastName;
        }
    }
}

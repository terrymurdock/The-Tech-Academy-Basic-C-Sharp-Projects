using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_pg131_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> thingsString = new Employee<string>();
            Employee<int> thingsInt = new Employee<int>();

            thingsString.Things = new List<string>() { "desk", "computer", "chair" };
            thingsInt.Things = new List<int>() { 2, 4, 6 };
            
            thingsString.ProcessAllThings();
            thingsInt.ProcessAllThings();
        }
    }
}

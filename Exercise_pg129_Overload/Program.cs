using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_pg129_Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee id1 = new Employee(321);
            Employee id2 = new Employee(654);

            Console.WriteLine(id1 == id2);
            Console.ReadLine();
        }
    }
}

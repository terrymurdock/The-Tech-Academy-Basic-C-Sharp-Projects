using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_pg126
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            IQuittable quit = new Employee();

            employee.SayName("Sample", "Student");
            quit.Quit("Employee has been added successfully.");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Pg140_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee() { firstName = "Joe", lastName = "Schmoe", iD = 1 });
            employeeList.Add(new Employee() { firstName = "Nathan", lastName = "Bjerke", iD = 2 });
            employeeList.Add(new Employee() { firstName = "Terry", lastName = "Murdock", iD = 3 });
            employeeList.Add(new Employee() { firstName = "Elaine", lastName = "Smith", iD = 4 });
            employeeList.Add(new Employee() { firstName = "Smitha", lastName = "Dante", iD = 5 });
            employeeList.Add(new Employee() { firstName = "Joe", lastName = "Cuppa", iD = 6 });
            employeeList.Add(new Employee() { firstName = "Emily", lastName = "Orillon", iD = 7 });
            employeeList.Add(new Employee() { firstName = "Ben", lastName = "Orillon", iD = 8 });
            employeeList.Add(new Employee() { firstName = "Linh", lastName = "Luong", iD = 9 });
            employeeList.Add(new Employee() { firstName = "Andy", lastName = "Luebner", iD = 10 });

            Console.WriteLine("USING LONG VERSION\n");
            foreach (Employee anEmployee in employeeList)
            {
                if (anEmployee.firstName == "Joe")
                {
                    Console.WriteLine(anEmployee);
                    Console.ReadLine();
                }
            }
            
            Console.WriteLine("USING LAMBDA EXPRESSION\n");
            foreach (Employee anEmployee in employeeList.FindAll(e => e.firstName == "Joe").ToList())
            {
                Console.WriteLine(anEmployee);
                Console.ReadLine();
            }

            Console.WriteLine("ID # > 5\n");
            foreach (Employee anEmployee in employeeList.Where(e => e.iD > 5).ToList())
            {
                Console.WriteLine(anEmployee);
                Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_pg126
{
    public class Employee : Person, IQuittable
    {
        public override void SayName(string firstName, string lastName)
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.ReadLine();
        }
        public void Quit(string text)
        {
            Console.WriteLine("Status: " + text);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_pg126
{
    public class Employee : Person, IQuittable
    {
        public void Quit(string text)
        {
            Console.WriteLine("Status: " + text);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_pg131_Generics
{
    public class Employee<T>
    {
        public List<T> Things { get; set; }

        public void ProcessAllThings()
        {
            foreach(var thing in Things)
            {
                Console.WriteLine(thing.ToString());
                Console.ReadLine();
            }
        }
    }
}

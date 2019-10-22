using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Pg156_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("The current date and time are: " + dt + ".");
            Console.WriteLine("Please provide a number.");
            int number = Convert.ToInt32(Console.ReadLine());

            // Add the number of hours the user entered to dt, then convert to time only in string format
            string futureTime = dt.AddHours(number).ToLongTimeString();
            Console.WriteLine("In {0} hours, the exact time will be {1}.", number, futureTime);
            Console.ReadLine();
        }
    }
}

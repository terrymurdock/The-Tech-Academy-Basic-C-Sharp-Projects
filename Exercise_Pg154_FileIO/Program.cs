using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise_Pg154_FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide an number.");
            string number = Console.ReadLine();

            File.WriteAllText(@"C:\Users\terrytown\Logs\numberlog.txt", number);

            Console.WriteLine("Your number is: " + number + ".");
            Console.ReadLine();
        }
    }
}

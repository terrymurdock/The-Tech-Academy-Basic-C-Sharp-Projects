using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Pg111
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a whole number on which to perform math operations:");
            int userNum = Convert.ToInt32(Console.ReadLine());

            ThreeMethods three = new ThreeMethods();

            int add = three.AddNum(userNum);
            double div = three.DivNum(userNum);
            double multi = three.MultiNum(userNum);
            Console.WriteLine("Method 1 add value is " + add + "\n" +
                              "Method 2 divide value is " + div + "\n" +
                              "Method 3 multiply value is " + multi);
            Console.ReadLine();
        }
    }
}

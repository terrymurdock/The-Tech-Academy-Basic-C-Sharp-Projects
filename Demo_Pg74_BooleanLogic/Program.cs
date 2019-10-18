using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            // All true
            Console.WriteLine(true && false); //false
            Console.WriteLine(true && true);  //true
            Console.WriteLine(false && false); //false

            // At least one true
            Console.WriteLine(true || true);  //true
            Console.WriteLine(true || false);  //true
            Console.WriteLine(false || false); //false

            // Left equals right
            Console.WriteLine(true == true);  //true
            Console.WriteLine(true == false); //false
            Console.WriteLine(false == false);  //true

            // Left does not equal right
            Console.WriteLine(true != true); //false
            Console.WriteLine(true != false);  //true
            Console.WriteLine(false != false); //false

            // Onle one is true
            Console.WriteLine(true ^ true); //false
            Console.WriteLine(true ^ false);  //true
            Console.WriteLine(false ^ false); //false

            Console.ReadLine();
        }
    }
}

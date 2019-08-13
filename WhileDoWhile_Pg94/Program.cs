using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDoWhile_Pg94
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WHILE STATEMENT\n");
            // Continue while loop until it reaches 5
            int num = 0;
            while (num < 5)
            {
                // Write num to screen
                Console.WriteLine("While statement " + num + " is true.");
                // Increment by 1 starting at 0
                num++;
            }

            Console.WriteLine("And we're done, because num reached 5.");
            Console.ReadLine();

            Console.WriteLine("DO WHILE STATEMENT\n");
            // Also continue while loop until it reaches 5
            int doNum = 0;
            // Begin do while loop until it reaches 5
            do
            {
                // Increment by 1
                doNum++;
                Console.WriteLine("Do While statement " + doNum + " is true.");
            }
            while (doNum < 5);

            Console.WriteLine("Oops, the do while statement reached 5 and included it, because no conditions are checked before entering the loop.");
            Console.ReadLine();
        }
    }
}

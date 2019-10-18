using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Terry";
            //// Escape sequences
            //string quote = "The man said, \"Hello, Terry\".\n Hello on a new line. \n \t Hello on a tab.";
            //// Double back slash equals a single back slash
            //string fileName = "C:\\Users\\Terry";

            //// String functions
            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //// Length of a variable
            //int length = name.Length;

            //// All letters uppercase or lowercase
            //name = name.ToUpper();
            //name = name.ToLower();

            //Console.WriteLine(length);
            //Console.ReadLine();

            //Strings are immutable - meaning they are not changed, a new string is created
            //string name = "Terry";
            //name = "Joe";

            //StringBuilder Class - dynamic object that can expand and collapse without the expensive memory overhead
            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Terry");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}

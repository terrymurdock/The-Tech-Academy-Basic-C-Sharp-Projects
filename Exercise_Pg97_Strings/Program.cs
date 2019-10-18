using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_Pg97
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONCATENATE THREE STRINGS");
            string begin = "The cow ";
            string middle = "jumped over ";
            string end = "the moon.";
            Console.WriteLine(begin + middle + end +
                              Environment.NewLine);
            
            Console.WriteLine("CONVERT STRING TO UPPERCASE");
            string myName = "terry murdock";
            myName = myName.ToUpper();
            Console.WriteLine(myName +
                              Environment.NewLine);

            Console.WriteLine("STRINGBUILDER PARAGRAPH");
            StringBuilder para = new StringBuilder();
            para.Append("My name is Terry Murdock. ");
            para.Append("I am enrolled at The Tech Academy. ");
            para.Append("I am studying Software Development.");
            Console.WriteLine(para);

            Console.ReadLine();
        }
    }
}

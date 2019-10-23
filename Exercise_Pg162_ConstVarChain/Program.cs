using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Pg162_ConstVarChain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONST VARIABLE\n");
            const int muliplyBy = 10;
            Console.WriteLine("Please provide a number.");
            int yourNum = Convert.ToInt32(Console.ReadLine()) * muliplyBy;
            Console.WriteLine("Ten times your number is: {0}.", yourNum);
            Console.ReadLine();

            Console.WriteLine("VARIABLE USING KEYWORD VAR\n");
            List<string> dogBreeds = new List<string>()
            { "Poodle", "Yorkshire Terrier", "Bulldog", "West Highland Terrier", "Schnauzer", "Bull Terrier" };
            var terriers = from breeds in dogBreeds where breeds.Contains("Terrier") select breeds;
            foreach (var dog in terriers)
            {
                Console.WriteLine(dog);
                Console.ReadLine();
            }

            Console.WriteLine("CHAINED CONSTRUCTORS\n");
            var newEmployee = new Employee("Terry Murdock");
            Console.WriteLine("The new employee in {0} is {1}.", newEmployee.Department, newEmployee.Name);
            Console.ReadLine();
        }
    }
}

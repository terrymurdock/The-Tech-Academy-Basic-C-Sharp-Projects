using System;

namespace Exercise_Pg115
{
    class Program
    {
        static void Main(string[] args)
        {
            FunTimes ft = new FunTimes();

            Console.WriteLine("Please enter a number: ");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("(Optional) Please enter another number:");
            string numTwo = Console.ReadLine();
            if (numTwo == "")
            {
                int newOne = ft.subtractingFun(numOne);
                Console.WriteLine("Not entering a second value results in: " + newOne);
            }
            else
            {
                int newValue = ft.subtractingFun(numOne, Convert.ToInt32(numTwo));
                Console.WriteLine("The resulting value is: " + newValue);
            }
            Console.ReadLine();
        }
    }
}

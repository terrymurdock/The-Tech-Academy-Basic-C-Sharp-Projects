using System;

namespace Exercise_Pg117
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Instantiated class
            MathFun mf = new MathFun();

            //3.
            Console.WriteLine("Please enter a number:");
            int userNum = Convert.ToInt32(Console.ReadLine());

            mf.Divide(userNum);
            mf.Divide(5, out int b);
            Console.WriteLine("Value is: " + b);
            Console.ReadLine();
        }
    }
}

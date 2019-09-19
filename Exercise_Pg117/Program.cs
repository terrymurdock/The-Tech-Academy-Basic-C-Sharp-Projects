using System;

namespace Exercise_Pg117
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Instantiated class
            //FunMath fm = new FunMath();

            //3.
            Console.WriteLine("Please enter a number:");
            double userNum = Convert.ToDouble(Console.ReadLine());

            //Tried creating variable to place in ReadLine, but cannot convert
            //to anything because it is a void method
            //int divResult = fm.MathFun(userNum);

            //Also tried placing fm.MathFun into ReadLine but recieved
            //no overload for ReadLine, which takes 1 argument
            //Console.ReadLine(fm.MathFun(userNum));

            //6. Because of static method inside static class had to
            //call name of class then name of method, FunMath.MathFun
            double div = FunMath.MathFun(userNum);
            Console.WriteLine("The value is: " + div);
            Console.ReadLine();
        }
    }
}

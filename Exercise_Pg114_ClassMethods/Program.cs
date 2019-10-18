using System;

namespace Exercise_Pg114
{
    class Program
    {
        static void Main(string[] args)
        {
            FunTimes ft = new FunTimes();

            int multi = ft.MathFun(12);
            double div = ft.MathFun(2.4);
            int add = ft.MathFun("8");
            Console.WriteLine(multi);
            Console.WriteLine(div);
            Console.WriteLine(add);
            Console.ReadLine();
        }
    }
}

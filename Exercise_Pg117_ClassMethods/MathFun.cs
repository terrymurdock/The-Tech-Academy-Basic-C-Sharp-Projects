using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Pg117
{
    public class MathFun
    {
        public void Divide(int a)
        {
            int div = a / 2;
            Console.WriteLine("The value is: " + div);
            Console.ReadLine(); 
        }

        public void Divide(int a, out int b)
        {
            a = 10;
            b = 20;
            int div = a / 10;
            Console.WriteLine("Value of div is: " + div);
            Console.ReadLine();
            
        }
    }
}

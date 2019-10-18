using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Pg113
{
    class VoidMethod
    {
        public void VoidMeth(int x, int y)
        {
            x = 5;
            int result = 10 / x;
            Console.WriteLine("The value of y is " + y);
            Console.ReadLine();
        }

    }
}

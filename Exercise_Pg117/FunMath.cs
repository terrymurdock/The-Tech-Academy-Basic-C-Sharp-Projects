using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Pg117
{
    //1. Created class with void method
    //6. Converted to static class, had to add static to
    //to methods because static classes can only have 
    //static methods
    static class FunMath
    {
        public static void MathFun(int a)
        {
            int div = a / 2;
            return;
        }

        //4. Method with output parameters
        //5. Overloaded method
        public static double MathFun(double a)
        {
            double div = a / 2;
            return div;
        }
    }
}
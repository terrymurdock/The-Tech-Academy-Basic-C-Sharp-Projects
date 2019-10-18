using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Pg114
{
    public class FunTimes
    {
        public int MathFun(int multiNum)
        {
            int x = 5;
            int result = x * multiNum;
            return result;
        }

        public double MathFun(double divNum)
        {
            int y = 6;
            int result = Convert.ToInt32(y / divNum);
            return result;
        }

        public int MathFun(string strNum)
        {
            int z = 9;
            int result = z + Convert.ToInt32(strNum);
            return result;
        }
    }
}

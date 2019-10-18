using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Pg111
{
    public class ThreeMethods
    {
        public int AddNum(int addResult)
        {
            int x = 10;
            int result = x + addResult;
            return result;
        }

        public double DivNum(double divResult)
        {
            int y = 33;
            double result = y / divResult;
            return result;
        }

        public double MultiNum(double multiResult)
        {
            double z = 15.5;
            double result = z * multiResult;
            return result;
        }
    }
}

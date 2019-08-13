using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //LISTS
        // Can use any datatype
        List<string> intList = new List<string>();
        intList.Add("Hello");
        intList.Add("Terry");

        intList.Remove("Terry");

        Console.WriteLine(intList[0]);
        Console.ReadLine();

        //// ARRAYS
        //// Good for when you have a FIXED quantity
        /// OR when you have a very large quantity of data - byte[] byteArray = new byte[5000]
        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;
        
        //// Once you set an array's length, it is set and cannot change
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();
    }
}

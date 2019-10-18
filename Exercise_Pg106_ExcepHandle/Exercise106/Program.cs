using System;

namespace Exercise106
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] numList = { 24, 36, 75, 98, 53 };
                Console.WriteLine("[{0}]", string.Join(", ", numList));
                Console.WriteLine("Please pick a number to divide into each of the numbers above:");
                int userNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Here are the results:");

                for (int i = 0; i < numList.Length; i++)
                {
                    Console.WriteLine(numList[i] / userNum);
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}

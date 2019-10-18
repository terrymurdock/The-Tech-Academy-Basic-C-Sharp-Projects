using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_pg134_Enums
{
    public enum DaysofWeek
    {
        Monday, 
        Tuesday, 
        Wednesday, 
        Thursday, 
        Friday, 
        Saturday, 
        Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current day of the week:");
            string userDayInput = Console.ReadLine();

            DaysofWeek day;

            try
            {
                day = (DaysofWeek)Enum.Parse(typeof(DaysofWeek), userDayInput);
                if (day.ToString() == userDayInput)
                {
                    Console.WriteLine("You are correct.");
                    Console.ReadLine();
                }
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
        }
    }
}

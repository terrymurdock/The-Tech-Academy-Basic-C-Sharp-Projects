﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Pg165_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age.");
            int userAge = Convert.ToInt32(Console.ReadLine());

            try
            {
                if (userAge == 0)
                {
                    throw new ArgumentException();
                }
                else if (userAge < 0)
                {
                    throw new NotSupportedException();
                }
                else
                {
                    int yearBorn = DateTime.Now.Year - userAge;
                    Console.WriteLine("The year you were born is {0}.", yearBorn);
                    Console.ReadLine();
                }
            }
            catch(ArgumentException)
            {
                Console.WriteLine("You must enter a number greater than zero.");
                Console.ReadLine();
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Only positive numbers are supported.");
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("An error has occurred, please contact your system administrator.");
                Console.ReadLine();
            }
        }
    }
}

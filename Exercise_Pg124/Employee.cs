using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Pg124
{
    public class Employee : Person
    {
        public override void SayName(string firstName, string lastName)
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.ReadLine();      
        }
    }
    }

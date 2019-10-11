using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Pg124
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public void SayName(string firstName, string lastName)
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
            Console.ReadLine();
        }
    }
}

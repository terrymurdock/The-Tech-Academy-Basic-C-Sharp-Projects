﻿using System;

namespace Exercise_Pg120
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.FirstName = "Sample";
            employee.LastName = "Student";

            employee.SayName();
            Console.ReadLine();
        }
    }
}

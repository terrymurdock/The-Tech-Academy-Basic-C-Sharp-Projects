﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_pg126
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
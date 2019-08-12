using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Car Insurance Approval
What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? True or False");
            bool duiYesNo = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int numTickets = Convert.ToInt32(Console.ReadLine());

            bool isApproved = ((age >= 15) && (duiYesNo = true) && (numTickets <= 3));
            Console.WriteLine("You have been approved for our car insurance: " + isApproved);
            Console.ReadLine();
        }
    }
}

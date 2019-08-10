using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"Anonymous Income Comparison Program
Person 1
Hourly Rate?");
        int per1HrRate = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hours worked per week?");
        int per1HrsWorkWk = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(@"Person 2
Hourly Rate?");
        int per2HrRate = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hours worked per week?");
        int per2HrsWorkWk = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Weekly salary of Person 1:");
        int per1WkSalary = per1HrRate * per1HrsWorkWk;
        Console.WriteLine(per1WkSalary);

        Console.WriteLine("Weekly salary of Person 2:");
        int per2WkSalary = per2HrRate * per2HrsWorkWk;
        Console.WriteLine(per2WkSalary);

        Console.WriteLine("Does Person 1 make more money than Person 2?");
        bool trueOrFalse = per1WkSalary > per2WkSalary;
        Console.WriteLine(trueOrFalse);
        Console.ReadLine();
    }
}

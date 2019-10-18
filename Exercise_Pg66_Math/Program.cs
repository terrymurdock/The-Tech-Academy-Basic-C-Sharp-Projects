using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please provide an integer: ");
        int multiplier = Convert.ToInt32(Console.ReadLine());
        int multiplyBy = multiplier * 50;
        Console.WriteLine("Your product is: " + multiplyBy);

        Console.WriteLine("Please provide another integer: ");
        int add = Convert.ToInt32(Console.ReadLine());
        int addTo = add + 25;
        Console.WriteLine("Your total is: " + addTo);

        Console.WriteLine("Please provide an integer again: ");
        string input = Console.ReadLine() + ".0";
        double num = Convert.ToDouble(input);
        double divideBy = num / 12.5;
        Console.WriteLine("Your quotient is: " + divideBy);

        Console.WriteLine("You know the drill: ");
        int userInput = Convert.ToInt32(Console.ReadLine());
        bool trueOrFalse = userInput > 50;
        Console.WriteLine("Your integer is greater than 50: " + trueOrFalse.ToString());

        Console.WriteLine("I swear, last time, just give me one more: ");
        int lastNum = Convert.ToInt32(Console.ReadLine());
        int remainder = lastNum % 7;
        Console.WriteLine("The remainder is: " + remainder);
        Console.ReadLine();
    }
}

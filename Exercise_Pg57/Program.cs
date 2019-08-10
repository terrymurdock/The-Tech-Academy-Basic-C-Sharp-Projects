using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"The Tech Academy
Student Daily Report");
        Console.WriteLine("What course are you on?");
        string currentCourse = Console.ReadLine();
        Console.WriteLine("What page number?");
        string currentPageNum = Console.ReadLine();
        int pageNum = Convert.ToInt32(currentPageNum);
        Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'.");
        string needHelp = Console.ReadLine();
        bool helpStatus = Convert.ToBoolean(needHelp);
        Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
        string posExperiences = Console.ReadLine();
        Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
        string feedback = Console.ReadLine();
        Console.WriteLine("How many hours did you study today?");
        string hrsStudied = Console.ReadLine();
        int studyHrs = Convert.ToInt32(hrsStudied);
        Console.ReadLine();
    }
}

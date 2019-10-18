using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.WriteLine("ARRAY OF STRINGS");
        string[] strArray = { "Dog", "Cat", "Hamster", "Fish" };
        Console.WriteLine("[{0}]", string.Join(", ", strArray));
        Console.WriteLine("Please provide the index of your favorite pet from the array above:");
        int indexFavPet = Convert.ToInt32(Console.ReadLine());
        int strArrayLen = strArray.Length;
        while (true)
        {
            bool favPetHigher = indexFavPet >= strArrayLen;
            if (!favPetHigher)
            {
                Console.WriteLine("Your favorite pet is a: " + strArray[indexFavPet] + Environment.NewLine);
                break;
            }
            Console.WriteLine("Sorry, the index number must be between 0 - " + (strArrayLen - 1) + ".\n" +
                                "Please pick again.");
            indexFavPet = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("ARRAY OF INTEGERS");
        int[] intArray = { 70, 65, 60, 55, 50 };
        Console.WriteLine("[{0}]", string.Join(", ", intArray));
        Console.WriteLine("Please provide the index of the age from the above array when you would like to retire:");
        int indexRetireAge = Convert.ToInt32(Console.ReadLine());
        int intArrayLen = intArray.Length;
        while (true)
        {
            bool retireAgeHigher = indexRetireAge >= intArrayLen;
            if (!retireAgeHigher)
            {
                Console.WriteLine("You would like to retire at age: " + intArray[indexRetireAge] + Environment.NewLine);
                break;
            }
            Console.WriteLine("Sorry, the index number must be between 0 - " + (intArrayLen - 1) + ".\n" +
                                "Please pick again.");
            indexRetireAge = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("LIST OF STRINGS");
        string[] listContinents = { "North America", "Europe", "Latin America", "Asia", "Australia", "Africa" };
        List<string> contVisit = new List<string>(listContinents);
        Console.WriteLine("({0})", string.Join(", ", listContinents));
        Console.WriteLine("Please provide the index of the continent you would most like to visit from the list above:");
        int indexContinent = Convert.ToInt32(Console.ReadLine());
        int contVisitLen = contVisit.Count;
        while (true)
        {
            bool continentHigher = indexContinent >= contVisitLen;
            if (!continentHigher)
            {
                Console.WriteLine("You would most like to visit: " + listContinents[indexContinent] + Environment.NewLine);
                break;
            }
            Console.WriteLine("Sorry, the index number must be between 0 - " + (contVisitLen - 1) + ".\n" +
                                "Please pick again.");
            indexContinent = Convert.ToInt32(Console.ReadLine());
        }
        Console.ReadLine();
    }
}

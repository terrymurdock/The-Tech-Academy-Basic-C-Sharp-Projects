using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        //1
        Console.WriteLine("1. LOOP THROUGH ARRAY & ADD STRING VALUES FROM USER\n");
        // Define one dimensional string array
        string[] progLangs = new string[3];
        // Iterate through array and add values
        Console.WriteLine("Enter programming languages...");
        for (int i = 0; i < 3; i++)
        {
            // Get string values from user
            Console.Write("\tProgramming language " + (i + 1) + ": ");
            progLangs[i] = Console.ReadLine();
        }
        // Write string values to console
        Console.Write("\nThe programming languages are...\n");
        for (int i = 0; i < 3; i++)
        {
            Console.Write("\tProgramming language " + (i + 1) + ": " + progLangs[i] + "\n");
        }
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();

        //2 & 3
        Console.WriteLine("2. INFINITE LOOP & 3. FIX\n");
        // 2. The loop would run infinitely because a is being decremented by 1 and would never reach 10
        //for (int a = 0; a < 10; a--)
        // 3. The fix - increment the value of a instead and then it will reach 10 and quit
        for (int a = 0; a < 10; a++)
        {
            Console.WriteLine("value : {0}", a);
        }
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();

        //4
        Console.WriteLine("4. LOOP USING \"<\" OPERATOR\n");
        for (int a = 0; a < 6; a++)
        {
            Console.WriteLine("Number: {0}", a);
        }
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();

        //5
        Console.WriteLine("5. LOOP USING \"<=\" OPERATOR\n");
        for (int a = 0; a <= 5; a++)
        {
            Console.WriteLine("Number: {0}", a);
        }
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();

        //6, 7, & 8
        Console.WriteLine("6. SEARCH FOR STRING IN LIST, 7. ERROR MESSAGE, 8. STOP PROGRAM\n");

        // Create list of unique string values
        List<string> electricCars = new List<string>() { "Volt", "Bolt", "Model S", "Model 3", "i3", "i8" };
        // Write list to console
        Console.WriteLine("[{0}]", string.Join(", ", electricCars));

        // Ask user to select from the list and write in the string value of their choice
        Console.WriteLine("Which electric car you would like to own:");
        string userElecCar = Console.ReadLine();
        // Convert user string value to index
        int indexUserCar = electricCars.FindIndex(a => a.Contains(userElecCar));

        // 6. Iterate through list while the boolean variable is true
        while (true)
        {
            bool isFound = indexUserCar >= electricCars.Count || indexUserCar < 0;
            // 8. Once the boolean variable is false write selection to the console and quit the program
            if (!isFound)
            {
                Console.WriteLine("You would like to own a: " + electricCars[indexUserCar] + Environment.NewLine);
                break;
            }
            // 7. Error message
            Console.WriteLine("You must select from the list above and write that exact value.\n" +
                                "Try again:");
            userElecCar = Console.ReadLine();
            indexUserCar = electricCars.FindIndex(a => a.Contains(userElecCar));
        }
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();

        //9 & 10
        Console.WriteLine("9. LIST WITH TWO IDENTICAL STRING VALUES, 10. ERROR MESSAGE\n");
        // Create list of unique string values
        List<string> animals = new List<string>() { "Bear", "Elephant", "Lion", "Tiger", "Zebra", "Gorilla", "Elephant", "Giraffe", "Tiger" };
        // Write list to console
        Console.WriteLine("[{0}]", string.Join(", ", animals));
        //DUPLICATES?
        // Determine if there is a duplicate
        var duplicatesWithIndices = animals
            // Associate each animal with an index
            .Select((Name, Index) => new { Name, Index })
            // Group according to animal
            .GroupBy(x => x.Name)
            // Only need Name -> {Index1, Index2, ...}
            .Select(xg => new { Name = xg.Key, Indices = xg.Select(x => x.Index) })
            // And groups with more than one index represent a duplicate key
            .Where(x => x.Indices.Count() > 1);
        // Count of duplicates
        int numDupes = animals.Count - animals.Distinct().Count();
        // Notify if there is a duplicate
        if (numDupes >= 1)
        {
            Console.WriteLine("\nDUPLICATE(S) FOUND:\n");
        }
        // Write duplicate and its indices to console
        foreach (var dupe in duplicatesWithIndices)
        {
            Console.WriteLine("Duplicated value: " + dupe.Name + " with indices " + string.Join(", ", dupe.Indices.ToArray()));
        }
        // Ask user to select from the list and write in the string value of their choice
        Console.WriteLine("\nSelect your favorite animal:");
        string userFavAnimal = Console.ReadLine();
        // Convert user string value to index
        int indexUserFav = animals.FindIndex(a => a.Contains(userFavAnimal));
        // Iterate through list while the boolean variable is true
        while (true)
        {
            bool isFound = indexUserFav >= animals.Count || indexUserFav < 0;
            // 9. Once the boolean variable is false write selection to the console and quit the program
            if (!isFound)
            {
                Console.WriteLine("You selected: " + animals[indexUserFav]);
                break;
            }
            // 10. Error message
            Console.WriteLine("You must select from the list above and write that exact value.\n" +
                                "Try again:");
            userFavAnimal = Console.ReadLine();
            indexUserFav = animals.FindIndex(a => a.Contains(userFavAnimal));
        }
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();

        //11
        Console.WriteLine("11. LIST WITH TWO IDENTICAL STRING VALUES, FOREACH LOOP, INDICATE DUPLICATES\n");
        // Create list of unique string values
        List<string> iceCreamFlavors = new List<string>() { "Vanilla", "Chocolate", "Salted Caramel", "Licorice", "Pecan Praline", "Salted Caramel", "Licorice" };
        // Blank list to add flavors to and determine if they have already been added
        List<string> tempIceCreamFlavors = new List<string>();
        foreach (var flavor in iceCreamFlavors)
        {
            // Adds first flavor only to get the temp list started
            if (tempIceCreamFlavors.Count == 0)
            {
                tempIceCreamFlavors.Add(flavor);
                Console.WriteLine("Flavor: " + flavor + "\t\tAlready exists? No");
            }
            else if (tempIceCreamFlavors.Contains(flavor))
            {
                Console.WriteLine("Flavor: " + flavor + "\tAlready exists? Yes");
                tempIceCreamFlavors.Add(flavor);
            }
            else
            {
                Console.WriteLine("Flavor: " + flavor + "\tAlready exists? No");
                tempIceCreamFlavors.Add(flavor);
            }
        }
        Console.ReadLine();
    }
}

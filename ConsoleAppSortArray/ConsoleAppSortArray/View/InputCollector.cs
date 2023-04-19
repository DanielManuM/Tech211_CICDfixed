namespace ConsoleAppSortArray;
using System;

public static class InputCollector
{
    public static int InputArrayLength()
    {
        bool isNumber = Int32.TryParse(Console.ReadLine(), out int value);
        while (!isNumber || value <= 0)
        {
            Console.WriteLine(!isNumber ? "Input must be an integer!" : "Please input length more than 0!!");
            isNumber = Int32.TryParse(Console.ReadLine(), out value);           
        }
        return value;
    }

    public static int InputSortType()
    {
        bool isNumber = Int32.TryParse(Console.ReadLine(), out int value);
        while (!isNumber || value > 4 || value < 1 )
        {
            Console.WriteLine("Please input numbers between 1 and 4!!");
            isNumber = Int32.TryParse(Console.ReadLine(), out value);
        }
        return value;
    }

    public static string InputDecision()
    {
        Console.WriteLine();
        Console.WriteLine("Would you like to re-run the program? y / n");
        string input = Console.ReadLine().ToLower();

        while (input != "y" && input != "n")
        {
            Console.WriteLine("Invalid selection. Please input 'y' or 'n'.");
            input = Console.ReadLine().ToLower();
        }

        return input;
    }

}

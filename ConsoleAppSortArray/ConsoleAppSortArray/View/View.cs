namespace ConsoleAppSortArray;

public static class View
{
    public static void DisplayGreeting()
    {
        Console.WriteLine("Welcome to the random array sorter!!");
    }

    public static void DisplayExitMessage()
    {
        Console.WriteLine("Goodbye.");
    }

    public static void InputTextDisplayArray()
    {
        Console.WriteLine();
        Console.Write("Please choose the length of the array: ");
    }

    public static void InputTextDisplaySort()
    {
        Console.WriteLine();
        Console.WriteLine("Press 1 for Bubble Sort");
        Console.WriteLine("Press 2 for Merge Sort");
        Console.WriteLine("Press 3 for .NET Sort");
        Console.WriteLine();
        Console.Write("Choice: ");
    }

    public static void Output(SortType sortType, int[] unsortedArray, int[] sortedArray, string elapsedTime)
    {
        Console.WriteLine();
        Console.WriteLine("Unsorted Array: " + string.Join(", ", unsortedArray));
        Console.WriteLine();
        Console.WriteLine($"Sorted Array (sorted using {sortType.MethodName}): {string.Join(", ", sortedArray)}");

        string seconds = elapsedTime.Substring(7);

        Console.WriteLine();
        Console.WriteLine("Elapsed Time: " + seconds + "s");
    }
}


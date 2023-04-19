using System.Diagnostics;

namespace ConsoleAppSortArray;

public class Controller
{
    public static void RunApp()
    {
        // Initial greeting
        View.DisplayGreeting();

        string run = "y";
        while (run == "y")
        {
            // Collect user input: array length and sort method
            View.InputTextDisplayArray();
            int arrayLength = InputCollector.InputArrayLength();
            View.InputTextDisplaySort();
            int sortType = InputCollector.InputSortType();

            // Generate specific sort object
            SortType? sortObject = Sorter.GetSortClass(sortType);

            //Generate random array
            int[] randArray = ArrayGenerator.RandomArrayGenerator(arrayLength);

            // Retain a copy of the original unsorted array
            int[] originalRandArray = (int[])randArray.Clone();

            // Get elapsed time
            int[] sortedArray;
            string elapsedTime = GetTime(sortObject, randArray, out sortedArray);

            // Display all outputs to the user
            View.Output(sortObject, originalRandArray, sortedArray, elapsedTime);

            // Prompt user to restart app or to exit
            run = InputCollector.InputDecision();
        }

        // Display goodbye message
        View.DisplayExitMessage();
    }

    public static string GetTime(SortType sortObject, int[] randArray, out int[] sortedArray)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        sortedArray = sortObject.Sort(randArray);
        stopwatch.Stop();
        return stopwatch.Elapsed.ToString();
    }
}
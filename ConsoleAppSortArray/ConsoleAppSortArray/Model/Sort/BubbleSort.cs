namespace ConsoleAppSortArray;

public class BubbleSortClass : SortType
{
    public override string MethodName => "bubble sort";
    public override int[] Sort(int[] inputArray)
    {
        int n = inputArray.Length;
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 1; i <= n - 1; i++)
            {
                if (inputArray[i - 1] > inputArray[i])
                {
                    int a = inputArray[i - 1];
                    inputArray[i - 1] = inputArray[i];
                    inputArray[i] = a;
                    swapped = true;
                }
            }
        } while (swapped);
        return inputArray;
    }
}

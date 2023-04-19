namespace ConsoleAppSortArray;

public class DotNetSortClass : SortType
{
    public override string MethodName => ".NET sort";
    public override int[] Sort(int[] inputArray)
    {
        Array.Sort(inputArray);
        return inputArray;
    }
}
namespace ConsoleAppSortArray;

public abstract class SortType
{
    public abstract string MethodName {get;}
    public abstract int[] Sort(int[] unsortedArray);
}
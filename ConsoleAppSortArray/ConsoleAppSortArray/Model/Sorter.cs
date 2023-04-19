namespace ConsoleAppSortArray;

public static class Sorter
{
    public static SortType? GetSortClass(int method) => method switch
    {
        1 => new BubbleSortClass(),
        2 => new MergeSort(),
        3 => new DotNetSortClass(),
        _ => null
    };
}
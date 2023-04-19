namespace ConsoleAppSortArray;

public class MergeSort : SortType
{
    public override string MethodName => "merge sort";
    public override int[] Sort(int[] unsortedArray) =>
        unsortedArray is null ? throw new ArgumentNullException(nameof(unsortedArray), "Input cannot be null.")
        : SplitArray(unsortedArray).ToArray();

    public List<int> SplitArray(int[] arr)
    {
        List<int> numList = arr.ToList();
        if (numList.Count <= 1) return numList;

        var left = new List<int>();
        var right = new List<int>();

        for (int i = 0; i < numList.Count; i++)
        {
            if (i < numList.Count / 2) left.Add(numList[i]);
            else right.Add(numList[i]);
        }

        left = SplitArray(left.ToArray());
        right = SplitArray(right.ToArray());

        return Merge(left, right);
    }

    public List<int> Merge(List<int> left, List<int> right)
    {
        var result = new List<int>();

        while (left.Count != 0 && right.Count != 0)
        {
            if (left[0] <= right[0])
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }
            else
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }
        }

        while (left.Count != 0)
        {
            result.Add(left[0]);
            left.RemoveAt(0);
        }
        while (right.Count != 0)
        {
            result.Add(right[0]);
            right.RemoveAt(0);
        }

        return result;
    }
}
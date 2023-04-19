namespace ConsoleAppSortArray;

using System;

public static class ArrayGenerator
{
    public static int[] RandomArrayGenerator(int arrayLength)
    {
        var randArray = new int[arrayLength];
        var rnd = new Random();

        for (int i = 0; i < arrayLength; i++)
        {
            randArray[i] = rnd.Next(-1000, 1000);
        }

        return randArray;
    }
}

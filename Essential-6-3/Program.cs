using System;
using System.Collections.Generic;

namespace Essential6_3;

public static class ArraySortExtension
{
    public static void SortInt(this int[] array)
    {
        Array.Sort(array);
    }
}

class Program
{
    static void Main()
    {
        int[] arr = { 3, 2, 1 };

        arr.SortInt();
        foreach (var item in arr)
        {
            Console.WriteLine(item) ;
        }
        Console.ReadLine();
    }
}
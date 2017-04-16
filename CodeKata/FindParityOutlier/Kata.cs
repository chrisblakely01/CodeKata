using System.Collections.Generic;
using System.Linq;
using System;

public class Kata
{
    public static int Find(int[] integers)
    {
        //at least 2 values must be odd/even so we check the first 3
        int firstThree = integers[0] % 2 + integers[1] % 2 + integers[2] % 2;

        int rem = firstThree < 2 ? 1 : 0;

        for (int i = 0; i < integers.Length; i++)
        {
            if (integers[i] % 2 == rem)
            {
                return integers[i];
            }
        }
        return -1;
    }

    public static int FindLinq(int[] integers)
    {
        var evenNumbers = integers.Where(integer => integer % 2 == 0);
        var oddNumbers = integers.Where(integer => integer % 2 == 1);
        return evenNumbers.Count() == 1 ? evenNumbers.First() : oddNumbers.First();
    }
}
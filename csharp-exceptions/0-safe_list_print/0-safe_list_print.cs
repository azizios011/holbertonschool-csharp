using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        try
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(myList[i]);
                count++;
            }
            return count;
        }

        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Warning: Attempted to print more elements than available in the list.");
            return myList.Count;
        }
    }
}

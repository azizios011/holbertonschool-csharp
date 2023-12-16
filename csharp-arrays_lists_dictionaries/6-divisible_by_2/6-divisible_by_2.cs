// a method that finds all multiples of 2 in a list.
using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        if (myList == null)
        {
            Console.WriteLine("List is null");
            return null;
        }

        List<bool> result = new List<bool>();

        foreach (int number in myList)
        {
            result.Add(number % 2 == 0);
        }

        return result;
    }
}

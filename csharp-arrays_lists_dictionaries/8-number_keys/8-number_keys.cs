// a method that returns the number of keys in a dictionary.
using System;
using System.Collections.Generic;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        if (myDict == null)
        {
            Console.WriteLine("Dictionary is null");
            return 0;
        }

        int count = 0;

        foreach (var key in myDict.Keys)
        {
            count++;
        }

        return count;
    }
}

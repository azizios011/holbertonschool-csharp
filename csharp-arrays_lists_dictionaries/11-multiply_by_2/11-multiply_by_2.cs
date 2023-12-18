// a method that returns a new dictionary with all values multiplied by 2.
using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        if (myDict == null)
        {
            Console.WriteLine("Dictionary is null");
            return null;
        }
        Dictionary<string, int> newDict = new Dictionary<string, int>();

        foreach (var entry in myDict)
        {
            newDict.Add(entry.Key, entry.Value * 2);
        }
        return newDict;
    }
}

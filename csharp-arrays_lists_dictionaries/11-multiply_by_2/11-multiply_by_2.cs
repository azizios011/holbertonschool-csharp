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
        foreach (var kvp in myDict)
        {
            myDict[kvp.Key] = kvp.Value * 2;
        }
        return myDict;
    }
}

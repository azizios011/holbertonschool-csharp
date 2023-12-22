using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        if (myDict == null)
        {
            Console.WriteLine("Dictionary is null");
            return;
        }

        List<string> sortedKeys = new List<string>(myDict.Keys);
        sortedKeys.Sort();

        foreach (var key in sortedKeys)
        {
            Console.WriteLine($"{key}: {myDict[key]}");
        }
    }
}

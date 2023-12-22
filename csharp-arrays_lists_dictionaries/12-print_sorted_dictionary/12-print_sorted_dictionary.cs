// a method that prints a dictionary by ordered keys.
using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        var new_dict = myDict.OrderBy(x => x.Key);
        foreach (var element in new_dict)
        {
            Console.WriteLine($"{element.Key}: {element.Value}");
        }
    }
}

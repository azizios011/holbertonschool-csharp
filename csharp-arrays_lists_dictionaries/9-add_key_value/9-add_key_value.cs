// a method that adds a key and value to a dictionary.
using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        if (myDict == null)
        {
            Console.WriteLine("Dictionary is null");
            return null;
        }
        else if (myDict.ContainsKey(key))
        {
            myDict[key] = value;
        }
        else
        {
            myDict.Add(key, value);
        }
        return myDict;
    }
}

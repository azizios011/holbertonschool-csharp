using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
    {
        if (myDict == null)
        {
            Console.WriteLine("Dictionary is null");
            return null;
        }
        if (myDict.ContainsKey(key))
        {
            myDict.Remove(key);
        }

        return myDict;
    }
}

// Write a method that returns the key with the biggest integer value in a given dictionary.
using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList == null)
        {
            Console.WriteLine("Dictionary is null");
            return "None";
        }

        if (myList.Count == 0)
        {
            Console.WriteLine("Dictionary is empty");
            return "None";
        }

        int maxScore = int.MinValue;
        string bestStudent = "None";

        foreach (var kvp in myList)
        {
            if (kvp.Value > maxScore)
            {
                maxScore = kvp.Value;
                bestStudent = kvp.Key;
            }
        }

        return bestStudent;
    }
}

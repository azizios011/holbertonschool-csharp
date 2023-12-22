// Write a method that returns the key with the biggest integer value in a given dictionary.
using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {   
        string best_student = "None";
        int max_score = int.MinValue;
        foreach(KeyValuePair<string, int> element in myList)
        {
            if (element.Value > max_score)
            {
                best_student = element.Key;
                max_score = element.Value;
            }
        } 
        return best_student;
    }
}

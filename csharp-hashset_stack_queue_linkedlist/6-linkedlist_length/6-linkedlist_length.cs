// a method that returns the number of elements in a LinkedList.
using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int count = 0;
        foreach (var node in myLList)
        {
            count++;
        }
        return count;
    }
}

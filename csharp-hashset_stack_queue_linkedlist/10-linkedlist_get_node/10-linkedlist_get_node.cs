// a method that returns the value of the nth node of a LinkedList.
using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        if (myLList != null && myLList.Count != 0)
        {
            int counter = 0;

            foreach (var nodeValue in myLList)
            {
                if (counter == n)
                {
                    return nodeValue;
                }
                counter++;
            }
        }
        return 0;
    }
}

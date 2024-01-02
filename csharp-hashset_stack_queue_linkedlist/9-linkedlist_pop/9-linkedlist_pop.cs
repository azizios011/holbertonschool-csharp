// a method that deletes the head node of a LinkedList and returns that node’s data.
using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList == null || myLList.Count == 0)
        {
            return 0;
        }

        int value = myLList.First.Value;
        myLList.RemoveFirst();

        return value;
    }
}

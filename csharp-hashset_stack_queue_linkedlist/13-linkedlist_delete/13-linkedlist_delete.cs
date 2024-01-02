// a method that deletes the node at given position in a LinkedList.
using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int idx = 0;
        foreach(var elem in myLList)
        {
            if(idx == index)
            {
                myLList.Remove(elem);
                return;
            }
            idx++;
        }
    }
}

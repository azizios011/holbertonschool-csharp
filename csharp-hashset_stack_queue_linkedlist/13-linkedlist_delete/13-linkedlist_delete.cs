// a method that deletes the node at given position in a LinkedList.
using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index < 0 || index >= myLList.Count)
        {
            Console.WriteLine("Invalid index");
            return;
        }

        LinkedListNode<int> current = myLList.First;
        for (int i = 0; i < index; i++)
        {
            current = current.Next;
        }

        myLList.Remove(current);
    }
}

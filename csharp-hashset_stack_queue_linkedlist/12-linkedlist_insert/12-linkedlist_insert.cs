// a method that inserts a new node in the correct position in an ordered LinkedList.
using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);

        LinkedListNode<int> CurrentNode = myLList.First;
        while(CurrentNode != null && CurrentNode.Value < n)
        {
            CurrentNode = CurrentNode.Next;
        }

        if (CurrentNode != null)
        {
            myLList.AddBefore(CurrentNode, newNode);
        }
        else
        {
            myLList.AddLast(newNode);
        }
        return newNode;
    }
}

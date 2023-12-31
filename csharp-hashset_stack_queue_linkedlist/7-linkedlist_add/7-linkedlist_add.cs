// a method that adds a node to the beginning of a LinkedList.
using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = myLList.AddFirst(n);
        return newNode;
    }
}

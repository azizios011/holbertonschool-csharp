// a method that creates and prints a LinkedList of integers of a given size.
using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> myLinkedList = new LinkedList<int>();
        if (size <= 0)
        {
            return myLinkedList;
        }

        for (int i = 0; i < size; i++)
        {
            myLinkedList.AddLast(i);
        }

        foreach(var item in myLinkedList)
        {
            Console.WriteLine(item);
        }

        return myLinkedList;
    }
}

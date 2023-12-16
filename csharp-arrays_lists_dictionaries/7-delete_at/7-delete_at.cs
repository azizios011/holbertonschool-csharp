// a method that deletes the item at a specific position in a list.
using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (myList == null)
        {
            Console.WriteLine("List is null");
            return null;
        }

        if (index < 0 || index >= myList.Count)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }

        List<int> updatedList = new List<int>(myList.Count - 1);

        for (int i = 0; i < myList.Count; i++)
        {
            if (i != index)
            {
                updatedList.Add(myList[i]);
            }
        }

        return updatedList;
    }
}

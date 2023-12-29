// a method that returns a sorted list of common elements in two lists.
using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> uniqueElements = new HashSet<int> (list1);
        List<int> commonElements = new List<int> ();

        foreach (var item in list2)
        {
            if (uniqueElements.Contains(item))
            {
                commonElements.Add(item);
                uniqueElements.Remove(item);
            }
        }
        commonElements.Sort();
        return commonElements;
    }
}

// a method that returns a sorted list of all elements present in one or the other list but not both.
using System;
using System, Collections, Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> uniqueElements = new HashSet<int> (list1);
        uniqueElements.SymmetricExceptWith(list2);

        List<int> differentElements = new List<int> (uniqueElements);
        differentElements.Sort();
        return differentElements;
    }
}

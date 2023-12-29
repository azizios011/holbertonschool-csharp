// a method that adds all unique integers in a list.
using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> myHashSet = new HashSet<int>();
        myHashSet.UnionWith(myList);
        
        int sum = 0;
        foreach ( var item in myHashSet)
        {
            sum += item;
        }
        return sum;
    }
}

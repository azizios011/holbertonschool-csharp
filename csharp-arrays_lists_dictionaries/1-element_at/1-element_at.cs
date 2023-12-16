// a method that retrieves an element from an array.
using System;

class Array
{
    public static int elementAt(int[] array, int index)
    {
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
            return -1;
        }
        else
        {
            return array[index];
        }
    }
}

// a method that replaces an element of an array at a given index.
using System;

class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("index out of range");
            return array;
        }
        else
        {
            array[index] = n;
            return array;
        }
    }
}

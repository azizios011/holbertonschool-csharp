// a method that prints all integers of an array, in reverse order.
using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null)
        {
            Console.WriteLine("Array is null");
            return;
        }

        for (int i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}

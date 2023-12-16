// a method that prints all integers of an array, in reverse order.
using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null)
        {
            Console.WriteLine();
            return;
        }
        if (array.Length > 0)
        {
            for (int i = array.Length - 1; i > -1; i--)
            {
                if (i != 0)
                    Console.Write($"{array[i]} ");
                else
                    Console.WriteLine($"{array[i]}");
            }
        }
        else
        {
            Console.WriteLine();
        }
    }
}

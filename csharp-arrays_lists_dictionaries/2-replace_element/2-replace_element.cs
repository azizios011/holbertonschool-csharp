﻿// a method that replaces an element of an array at a given index.
using System;

class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        if (index < 0 || index > array.Length - 1)
        {
            Console.WriteLine("Index out of range");
            return array;
        }
        else
        {
            array[index] = n;
            return array;
        }
    }
}

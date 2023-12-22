// a program that creates and prints a 5 by 5 two-dimensional array and initialize index [2,2] to 1 and all other indices to 0.
using System;

class Program
{
    static void Main()
    {
        int[,] array = new int[5, 5];

        array[2, 2] = 1;

        Print2DArray(array);
    }

    static void Print2DArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

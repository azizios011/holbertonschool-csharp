// a program that creates and prints a 5 by 5 two-dimensional array and initialize index [2,2] to 1 and all other indices to 0.
using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int [5,5];
        int i;
        int j;
        for (i = 0; i < 5 ;i++)
        {
            for (j = 0; j < 5; j++)
            {
                if (i == 2 && j == 2)
                {
                    array[i , j] = 1;
                    Console.Write("{0} ", array[i, j]);
                }
                else if (j==4)
                {
                    Console.Write("{0}",array[i, j]);
                }
                else
                {
                    Console.Write("{0} ", array[i,j]);
                }
            }
            Console.Write("\n");
        }
    }
}

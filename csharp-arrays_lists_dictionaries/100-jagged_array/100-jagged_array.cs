using System;

class Program
{
    static void Main()
    {
        int[][] jaggedArray = new int[][]
        {
            new int[] {0, 1, 2, 3},
            new int[] {0, 1, 2, 3, 4, 5, 6},
            new int[] {0, 1}
        };

        PrintJaggedArray(jaggedArray);
    }

    static void PrintJaggedArray(int[][] jaggedArray)
    {
        foreach (var array in jaggedArray)
        {
            Console.WriteLine(string.Join(" ", array));
        }
    }
}

using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int[] newArray = new int[size];

        for (int i = 0; i < size; i++)
        {
            newArray[i] = i;
            Console.Write(i + " ");
        }

        Console.WriteLine(); // Move to the next line after printing the array
        return newArray;
    }
}

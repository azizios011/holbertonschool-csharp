// a function that divides element by element 2 lists.
using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();
        try
        {
            for (int i = 0; i < listLength; i++)
            {
                
                    int element1 = list1[i];
                    int element2 = list2[i];

                    if (element2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero");
                        result.Add(0);
                    }

                    else
                    {
                        int divisionResult = element1 / element2;
                        result.Add(divisionResult);
                    }
            }
        }

        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Out of range");
        }

        return result;
    }
}

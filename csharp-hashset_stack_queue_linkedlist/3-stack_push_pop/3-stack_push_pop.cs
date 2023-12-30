// a method that check a stack for it's info.
using System;
using System.Collections.Generic;
using System.Linq;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aStack.Count}");

        if (aStack.Count > 0)
        {
            string topItem = aStack.Peek();
            Console.WriteLine($"Top item: {topItem}");

            bool containsSearch = aStack.Contains(search);
            Console.WriteLine($"Stack contains {search}: {containsSearch}");

            if (containsSearch)
            {
                Stack<string> tempStack = new Stack<string>();
                bool found = false;

                while (aStack.Count > 0)
                {
                    string currentItem = aStack.Pop();
                    if (currentItem == search)
                    {
                        found = true;
                        break;
                    }
                    tempStack.Push(currentItem);
                }

                while (tempStack.Count > 0)
                {
                    aStack.Push(tempStack.Pop());
                }

                if (found)
                {
                    aStack.Pop();
                }
            }
        }
        else
        {
            Console.WriteLine("Stack is empty");
        }

        aStack.Push(newItem);

        return aStack;
    }
}

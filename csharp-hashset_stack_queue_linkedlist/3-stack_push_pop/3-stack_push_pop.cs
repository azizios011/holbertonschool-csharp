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
                while (aStack.Count > 0 && aStack.Peek() != search)
                {
                    tempStack.Push(aStack.Pop());
                }
                if (aStack.Count > 0)
                {
                    aStack.Pop();
                }
                while (tempStack.Count > 0)
                {
                    aStack.Push(tempStack.Pop());
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

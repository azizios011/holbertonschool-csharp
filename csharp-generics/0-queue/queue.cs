using System;

public class Queue<T>
{
    public string CheckType()
    {
        return typeof(T).FullName;
    }
}
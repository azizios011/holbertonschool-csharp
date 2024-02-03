using System;

class Obj
{
    /// <summary>
    /// a method that returns True if the object is an int, otherwise return False.
    /// </summary>
    public  static bool IsOfTypeInt(object obj)
    {
        return obj.GetType() == typeof(int);
    }
}

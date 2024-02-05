using System;
using System.Collections.Generic;

class Obj
{
    /// <summary>
    /// a method that returns 'True' if the object is an instance of, or if the object is an instance of a class that inherited from,"Array", otherwise return 'False'.
    /// </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        return obj.GetType().IsInstanceOfType(typeof(Array));
    }
}

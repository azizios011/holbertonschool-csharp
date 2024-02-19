using System;
using System.Collections.Generic;

class Shape
{
    /// <summary>
    /// public method 'Area' that Throw an 'NotImplementedException' with the message 'Area() is not implemented'.
    /// </summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }
}

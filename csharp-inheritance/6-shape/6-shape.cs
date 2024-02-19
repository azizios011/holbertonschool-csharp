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

class Rectangle : Shape
{

    /// <summary>
    /// a private field 'width'.
    /// </summary>
    private int width;

    /// <summary>
    /// a private field 'height'.
    /// </summary>
    private int height;

    /// <summary>
    /// a public property 'Width' that  retrieve 'width' and throw an 'ArgumentException' with a message  if value is negative Otherwise, set width to the value.
    /// </summary>
    public int Width
    {
        get{return width;}
        set {
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }

            width = value;
        }
    }

    /// <summary>
    /// a public property 'Height' that retrieve 'height' and throw an ArgumentException with a message if value is negative, Otherwise, set Height to the value.
    /// </summary>
    public int Height
    {
        get{return height;}

        set{
            if(value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }

            height = value;
        }
    }
}
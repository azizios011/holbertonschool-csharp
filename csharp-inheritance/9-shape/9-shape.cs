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

    /// <summary>
    /// Calculates the area of the rectangle.
    /// </summary>
    /// <returns>The area of the rectangle (Width * Height).</returns>
    public new int Area()
    {
        return  Width * Height;
    }

    /// <summary>
    /// Returns a string representation of the rectangle.
    /// </summary>
    /// <returns>A formatted string indicating the type, width, and height of the rectangl.</returns>
    public override string ToString()
    {
        return $"[Rectangle] {Width} / {Height}";
    }
}

class Square : Rectangle
{
    /// <summary>
    /// a private field 'size'.
    /// </summary>
    private int size;

    /// <summary>
    /// a public property 'Size' that etrieve 'size' and throw an 'ArgumentException' with a message, Otherwise, set 'size', 'height', and 'width' to the value.
    /// </summary>
    public int Size
    {
        get{ return size;}

        set{
            if (value < 0)
            {
                throw new ArgumentException("Size must be greater than or equal to 0");
            }

            size = value;
            Width = value;
            Height = value;
        }
    }

    /// <summary>
    ///  Returns a string representation of the Square.
    /// </summary>
    /// <returns>return [Square] size / size.</returns>
    public override String ToString()
    {
        return $"[Square] {size} / {size}";
    }
}

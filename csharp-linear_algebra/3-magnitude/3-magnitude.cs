using System;

/// <summary>
/// abstract class named VectorMath.
/// </summary>
class VectorMath
{
    /// <summary>
    /// a method that calculates and returns the length of a given vector.
    /// </summary>
    public static double Magnitude(double[] vector)
    {
        if (vector.Length != 2 && vector.Length != 3)
        {
            return -1;
        }

        double sumOfSquares = 0.0;
        foreach (double component in vector) {
            sumOfSquares += component * component;
        }

        double magnitude = Math.Sqrt(sumOfSquares);

        magnitude = Math.Round(magnitude * 100.0) / 100.0;

        return magnitude;
    }

    /// <summary>
    /// a test method for testing the previous method.
    /// </summary>
    public static void Main(string[] args)
    {
        double[] vector2D = { 3, 4 };
        double[] vector3D = { 7, -3, -9 };
        double[] invalidVector = { 1, 2, 3, 4 };

        Console.WriteLine("Magnitude of vector2D: " + Magnitude(vector2D));
        Console.WriteLine("Magnitude of vector3D: " + Magnitude(vector3D));
        Console.WriteLine("Magnitude of invalidVector: " + Magnitude(invalidVector));
    }
}
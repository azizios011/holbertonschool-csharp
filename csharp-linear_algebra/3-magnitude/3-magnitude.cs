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

}
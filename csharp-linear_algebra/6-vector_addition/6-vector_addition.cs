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
    /// a method that adds two vectors and returns the resulting vector.
    /// </summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        double[] result = new double[vector1.Length];
        for (int i = 0; i < vector1.Length; i++)
        {
            result[i] = vector1[i] + vector2[i];
        }
        return result;
    }
}
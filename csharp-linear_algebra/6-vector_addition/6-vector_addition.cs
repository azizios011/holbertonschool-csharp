using System;

/// <summary>
/// Class named VectorMath.
/// </summary>
class VectorMath
{
    /// <summary>
    /// A method that calculates and returns the length of a given vector.
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
    /// A method that adds two vectors and returns the resulting vector.
    /// The vectors can be 2D or 3D. If any vector is not a 2D or 3D vector, or if the vectors are not of the same size, return a vector containing -1.
    /// </summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if ((vector1.Length != 2 && vector1.Length != 3) || 
            (vector2.Length != 2 && vector2.Length != 3) || 
            (vector1.Length != vector2.Length))
        {
            return new double[] { -1 };
        }

        double[] result = new double[vector1.Length];
        for (int i = 0; i < vector1.Length; i++)
        {
            result[i] = vector1[i] + vector2[i];
        }
        return result;
    }
}

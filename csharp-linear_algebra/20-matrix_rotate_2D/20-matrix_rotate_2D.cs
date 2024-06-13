﻿using System;

namespace MatrixMath
{
    public class MatrixMath
    {
        /// <summary>
        /// Rotates a square 2D matrix by a given angle in radians.
        /// </summary>
        public static double[,] Rotate2D(double[,] matrix, double angle)
        {
            int n = matrix.GetLength(0);

            // Check if the matrix is square
            if (n != matrix.GetLength(1))
            {
                return new double[,] { { -1 } };
            }

            double cosTheta = Math.Cos(angle);
            double sinTheta = Math.Sin(angle);
            double[,] result = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Apply rotation to the value at matrix[i, j]
                    double x = i;
                    double y = j;
                    double newX = x * cosTheta - y * sinTheta;
                    double newY = x * sinTheta + y * cosTheta;

                    // Assign the rotated value to the corresponding position in the result matrix
                    result[i, j] = matrix[i, j] * (cosTheta + sinTheta);
                }
            }

            return result;
        }
    }
}

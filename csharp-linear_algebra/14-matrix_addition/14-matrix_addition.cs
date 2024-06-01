using System;

namespace MatrixMath
{
    public class MatrixMath
    {
        public static double[,] Add(double[,] matrix1, double[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);

            // Check if both matrices are either 2x2 or 3x3 and of the same size
            if ((rows1 != 2 && rows1 != 3) || (cols1 != 2 && cols1 != 3) ||
                (rows1 != rows2) || (cols1 != cols2))
            {
                return new double[,] { { -1 } };
            }

            // Initialize the resulting matrix
            double[,] result = new double[rows1, cols1];

            // Add the corresponding elements of the two matrices
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols1; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }
    }
}

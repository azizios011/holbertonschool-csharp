using Systm;

public class MatrixMath
{
    /// <summary>
    /// Adds two matrices and returns the resulting matrix.
    /// The matrices can be either both 2D (2x2) or both 3D (3x3).
    /// If the matrices are not the same size or not 2D or 3D, a matrix containing -1 is returned.
    /// </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        // Check if both matrices are either 2D or 3D and have the same dimensions
        if ((matrix1.GetLength(0) == 2 && matrix1.GetLength(1) == 2 && matrix2.GetLength(0) == 2 && matrix2.GetLength(1) == 2) ||
            (matrix1.GetLength(0) == 3 && matrix1.GetLength(1) == 3 && matrix2.GetLength(0) == 3 && matrix2.GetLength(1) == 3))
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            double[,] result = new double[rows, cols];

            // Add corresponding elements of both matrices
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }
        else
        {
            // Return a matrix containing -1 if validation fails
            return new double[,] { { -1 } };
        }
    }
}

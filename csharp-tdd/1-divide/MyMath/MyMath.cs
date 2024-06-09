namespace MyMath;

public class Matrix
{
    public static int[,] Divide(int[,] matrix, int num)
    {
        if (num == 0 && matrix.Length == 0)
        {
            throw new DivideByZeroException();
            return null;
        }
        try {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] /= num;
                }
            }
            return matrix;
        }

        catch (DivideByZeroException)
        {
            return null;
        }
    }
}

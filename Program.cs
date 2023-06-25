using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int determinant = CalculateDeterminant(matrix);

        Console.WriteLine("The determinant of the matrix is: {0}", determinant);

        Console.ReadKey();
    }

    static int CalculateDeterminant(int[,] matrix)
    {
        int det = 0;

        det += matrix[0, 0] * matrix[1, 1] * matrix[2, 2];
        det += matrix[0, 1] * matrix[1, 2] * matrix[2, 0];
        det += matrix[0, 2] * matrix[1, 0] * matrix[2, 1];

        det -= matrix[0, 2] * matrix[1, 1] * matrix[2, 0];
        det -= matrix[0, 1] * matrix[1, 0] * matrix[2, 2];
        det -= matrix[0, 0] * matrix[1, 2] * matrix[2, 1];

        return det;
    }
}
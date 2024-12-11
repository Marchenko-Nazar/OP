using System;

class Program
{
    static void Main()
    {
        // Приклад квадратної матриці
        int[,] matrix =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Вивід вихідної матриці
        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        int columnCount = ModifyMatrix(matrix);

        // Вивід зміненої матриці
        Console.WriteLine("\nModified Matrix:");
        PrintMatrix(matrix);

        // Вивід кількості стовпців
        Console.WriteLine($"\nNumber of columns: {columnCount}");
    }

    static int ModifyMatrix(int[,] matrix)
    {
        int size = matrix.GetLength(0); 

        for (int col = 0; col < size; col++)
        {
            int diagonalValue = matrix[size - col - 1, col];

            for (int row = 0; row < size; row++)
            {
                matrix[row, col] *= diagonalValue; 
            }
        }

        return size; 
    }

    static void PrintMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

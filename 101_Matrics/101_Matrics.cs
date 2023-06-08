using System.Data;
using System.Numerics;
using System.Runtime.Serialization;

int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

int[,] matrix = CreateMatrix(sizes[0], sizes[1]);

MaxSumSquareInMatrix(matrix);

static int[,] CreateMatrix(int rows, int cols)
{
    int[,] matrix = new int[rows, cols];

    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        var rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            matrix[row, col] = rowData[col];
        }
    }
    return matrix;
}

static void ReadMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        var rowData = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            matrix[row, col] = rowData[col];
        }
    }
}

static void PrintMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            Console.Write(matrix[row, col] + " ");
        }

        Console.WriteLine();
    }
}

static int SumMatrix(int[,] matrix)
{
    int sum = 0;
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            sum += matrix[row, col];
        }
    }

    return sum;
}

static void PrintSumColumnsMatrix(int[,] matrix)
{
    for (int col = 0; col < matrix.GetLength(1); col++)
    {
        int sumColumn = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            sumColumn += matrix[row, col];
        }

        Console.WriteLine(sumColumn);
    }
}

static void MaxSumSquareInMatrix(int[,] matrix)
{
    int maxSum = int.MinValue;
    int maxRow = 0;
    int maxCol = 0;

    for (int row = 0; row < matrix.GetLength(0) - 1; row++)
    {
        for (int col = 0; col < matrix.GetLength(1) - 1; col++)
        {
            int sum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];

            if (sum > maxSum)
            {
                maxSum = sum;
                maxRow = row;
                maxCol = col;
            }
        }
    }

    Console.WriteLine(matrix[maxRow, maxCol] + " " + matrix[maxRow, maxCol + 1]);
    Console.WriteLine(matrix[maxRow + 1, maxCol] + " " + matrix[maxRow, maxCol]);
    Console.WriteLine(maxSum);
}
using System.Data;
using System.Numerics;
using System.Security.Cryptography;
using System.Threading.Channels;


int rows = int.Parse(Console.ReadLine());

int[][] matrix = new int[rows][];

static void ReadMatrix(int[][] matrix)
{
    for (int row = 0; row < matrix.Length; row++)
    {
        int[] rowData = Console.ReadLine().Split().Select(int.Parse).ToArray();

        matrix[row] = new int[rowData.Length];

        for (int col = 0; col < rowData.Length; col++)
        {
            matrix[row][col] = rowData[col];
        }
    }
}

static void PrintMatrix(int[][] matrix)
{
    for (int row = 0; row < matrix.Length; row++)
    {
        for (int col = 0; col < matrix[row].Length; col++)
        {
            Console.Write(matrix[row][col] + " ");
        }
        Console.WriteLine();
    }
}

static void PrintMatrixForeach(int[][] matrix)
{
    foreach (var item in matrix)
    {
        Console.WriteLine(string.Join(" ", item));
    }
}

static void JaggedArrayModification(int[][] matrix)
{
    ReadMatrix(matrix);

    string command = Console.ReadLine();
    while (command != "END")
    {
        var splitted = command.Split(" ");
        var row = int.Parse(splitted[1]);
        var col = int.Parse(splitted[2]);
        var value = int.Parse(splitted[3]);
        var isInvalid = false;

        if (matrix.Length <= row || row < 0)
        {
            isInvalid = true;
        }
        else if (matrix[row].Length <= col || col < 0)
        {
            isInvalid = true;
        }

        if (isInvalid)
        {
            Console.WriteLine("Invalid coordinates");
        }
        else
        {
            if (splitted[0] == "Add")
            {
                matrix[row][col] += value;
            }
            if (splitted[0] == "Subtract")
            {
                matrix[row][col] -= value;
            }
        }

        command = Console.ReadLine();
    }

    PrintMatrixForeach(matrix);
}

static void PascalTrianglel(int[][] matrix)
{
    int cols = 1;

    for (int row = 0; row < matrix.Length; row++)
    {
        matrix[row] = new int[cols];
        matrix[row][0] = 1;
        matrix[row][matrix[row].Length - 1] = 1;

        if (row > 1)
        {
            for (int col = 1; col < matrix[row].Length - 1; col++)
            {
                matrix[row][col] = matrix[row - 1][col] + matrix[row - 1][col - 1];
            }
        }

        cols++;
    }

    PrintMatrixForeach(matrix);
}
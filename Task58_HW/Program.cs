// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.Например, даны 2 матрицы:



int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}
void PrintArray(int[,] matrix2D)
{
    for (int i = 0; i < matrix2D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2D.GetLength(1); j++)
        {
            Console.Write($"{matrix2D[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        Console.WriteLine("Невозможно перемножить матрицы, если число строк одной не равно ислу столбцов другой");
        return matrixC;
    }
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return matrixC;
}

Console.Clear();

int[,] matrixA = GetArray(2, 2, -10, 10);
PrintArray(matrixA);
Console.WriteLine();
int[,] matrixB = GetArray(2, 2, -10, 10);
PrintArray(matrixB);
Console.WriteLine();
int[,] matrixC = MultiplyMatrix(matrixA, matrixB);
PrintArray(matrixC);


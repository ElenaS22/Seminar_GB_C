// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


double[,] GetArray(int m, int n, int MaxValue, int MinValue)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(MinValue + new Random().NextDouble() * (MaxValue - MinValue), 1);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    {

        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Console.Write($"{inArray[i, j]:f1}\t");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();

Console.Write("Введите количество строк =  ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов =  ");
int col = int.Parse(Console.ReadLine()!);

double[,] array2D = GetArray(row, col, -100, 100);
PrintArray(array2D);
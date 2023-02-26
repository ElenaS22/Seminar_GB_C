// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. Например, задан массив:

Console.Clear();

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

void SortfromMaxtoMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

int[,] array2d = GetArray(4, 4, 1, 9);
PrintArray(array2d);
Console.WriteLine();
SortfromMaxtoMin(array2d);
PrintArray(array2d);
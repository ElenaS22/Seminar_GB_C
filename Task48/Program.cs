// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


int[,] GetArray(int m, int n, int MinValue, int MaxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(MinValue, MaxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    {

        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                Console.Write($"{inArray[i, j]}\t ");
            }
            Console.WriteLine();
        }
    }
}

void ChangeRows(int[,] myArray)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        int temp = myArray[0, j];
        myArray[0, j] = myArray[myArray.GetLength(0) - 1, j];
        myArray[myArray.GetLength(0) - 1, j] = temp;
    }
}

Console.Clear();

Console.Write("Введите количество строк =  ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов =  ");
int col = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(row, col, -100, 100);
PrintArray(array2D);

Console.WriteLine();

ChangeRows(array2D);
PrintArray(array2D);
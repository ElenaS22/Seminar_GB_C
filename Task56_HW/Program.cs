// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

// string FindSum(int[,] myinArray)
// {
//     string result = "Сумма элементов в строке = ";
//     double sum;    
//     for (int j = 0; j < myinArray.GetLength(1); j++)
//     {
//         sum = 0;
//             for (int i = 0; i < myinArray.GetLength(0); i++)
//         {
//             sum = sum + myinArray[j, i];
//         }
//         result += $"{sum}";
//         if (j != myinArray.GetLength(1) - 1) result += "; ";
//         else result += ".";
//     }
//     return result;
    
// }

void FindMinSum(int[,] array)
{

    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minRow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.Write($"Наименьшая сумма элементов находится в {minSumRow + 1} строке");

}
int[,] array2d = GetArray(4, 4, 1, 9);
PrintArray(array2d);
Console.WriteLine();
FindMinSum(array2d);

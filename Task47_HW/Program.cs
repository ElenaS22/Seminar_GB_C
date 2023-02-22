// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


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

string AverageArifm(int[,] myinArray)
{
    string result = "Среднее арифметическое каждого столбца в массиве = ";
    double sum;
    double average;

    for (int i = 0; i < myinArray.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < myinArray.GetLength(0); j++)
        {
            sum = sum + myinArray[j, i];
        }
        average = sum / myinArray.GetLength(0);
        result += $"{average:f1}";
        if (i != myinArray.GetLength(1) - 1) result += "; ";
        else result += ".";
    }
    return result;
}

Console.Clear();

Console.Write("Введите количество строк в двухмерном массиве =  ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов в двухмерном массиве =  ");
int col = int.Parse(Console.ReadLine()!);

int[,] Array2D = GetArray(row, col, -10, 10);
PrintArray(Array2D);
Console.WriteLine(AverageArifm(Array2D));
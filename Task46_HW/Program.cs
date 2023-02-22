// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет


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


string CheckPositionInArray(int m, int n, int[,] inArray)
{
    if (m < 0 || n < 0) return "значения чисел должны быть больше нуля";
    string result;
    bool NewElement = m <= inArray.GetLength(0) - 1 && n <= inArray.GetLength(1) - 1;

    if (NewElement)
    {
        result = $"Элемент с индексом [{m} , {n}] имеет значение {inArray[m, n]}";
    }
    else
    {
        result = $"Элемент с индексом [{m} , {n}] отсутствует";
    }
    return result;
}

Console.Clear();


int row = new Random().Next(3, 6);
int col = new Random().Next(3, 6);
int[,] myArray = GetArray(row, col, -10, 10);
PrintArray(myArray);
Console.WriteLine();

Console.Write("Введите позицию элемента в двухмерном массиве (две цифры) через пробел: ");
int[] position = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
int m = position[0];
int n = position[1];
Console.WriteLine(CheckPositionInArray(m, n, myArray));



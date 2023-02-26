// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.


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

int[,] Transparent(int[,] myArray)
{
    int[,] transparent1 = new int[myArray.GetLength(1), myArray.GetLength(0)];
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
       transparent1[j,i] = myArray[i,j];        }
    }
    return transparent1;
}

Console.Clear();

Console.Write("Введите количество строк =  ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов =  ");
int col = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(row, col, -100, 100);
PrintArray(array2D);
Console.WriteLine();
if (row != col)
{
    Console.WriteLine("Выполнить переворот массива невоpможно");
}
else
{
Transparent(array2D);
PrintArray(Transparent(array2D));
}
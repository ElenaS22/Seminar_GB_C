// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int[,] GetArray(int m, int n, int MinValue, int MaxValue)
{
    int[,] result = new int[m,n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(MinValue, MaxValue + 1);
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

int GetSummOfArrayDiag(int[,] array2D)
{
    int sum = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        sum += array2D[i, i];
    }
  return sum;
}
Console.Clear();

int[,] MyArray = GetArray(4, 4, 1, 9);
PrintArray(MyArray);
int result = GetSummOfArrayDiag(MyArray);
Console.WriteLine();
Console.WriteLine(result);
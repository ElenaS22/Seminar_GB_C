// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на ихbквадраты.


Console.Clear();

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

void GetSqrArray(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i+=2)
    {
    //     if (i %2 != 0) continue;  
        for (int j = 0; j < array2D.GetLength(0); j+=2)
        {
            // if (j %2 == 0) 
            array2D[i,j] *= array2D[i,j] ;       
            }
    }
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

Console.Write("row =  ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("col =  ");
int col = int.Parse(Console.ReadLine()!);

int[,] array2D = GetArray(row,col, -10,10);
PrintArray(array2D);

Console.WriteLine();

GetSqrArray(array2D);
PrintArray(array2D);
// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


Console.Clear();


int[,] GetArray(int row, int col)
{
    int[,] array = new int[row,col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i,j] = i + j;
        }
   
    }
    return array;
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

int[,] array2D = GetArray(row,col);
PrintArray(array2D);
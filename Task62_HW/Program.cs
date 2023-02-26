// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] GetArray(int n)
{
    int[,] array2D = new int[n, n];
    return array2D;
}

void SpiralArray(int[,] array2D)
{
    int n = array2D.GetLength(0);
    int k = 0;
    bool[,] newmatrix = new bool[n, n];
    bool Out = false;
    int x = 0;
    int y = 0;
    while (!Out)
    {
        Out = true;
        while (y < n - 1 && !newmatrix[x, y + 1])
        {
            Out = false;
            array2D[x, y] = k++;
            newmatrix[x, y] = true;
            ++y;
        }
        while (x < n - 1 && !newmatrix[x + 1, y])
        {
            Out = false;
            array2D[x, y] = k++;
            newmatrix[x, y] = true;
            ++x;
        }
        while (y > 0 && !newmatrix[x, y - 1])
        {
            Out = false;
            array2D[x, y] = k++;
            newmatrix[x, y] = true;
            --y;
        }
        while (x > 0 && !newmatrix[x - 1, y])
        {
            Out = false;
            array2D[x, y] = k++;
            newmatrix[x, y] = true;
            --x;
        }
        array2D[x, y] = k;
    }
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


Console.Clear();
Console.Write("Введите количество строк и столбцов квадратной матрицы ");
int N = int.Parse(Console.ReadLine()!);
int[,] myArray = GetArray(N);
SpiralArray(myArray);
PrintArray(myArray);
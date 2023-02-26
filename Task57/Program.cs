//Задача 57: Составить частотный словарь элементов информацию о том, сколько раз встречается элемент входных данных.


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

int[] Transform2Dto1D(int[,] array2D)
{
    int[] array1D = new int[array2D.GetLength(0) * array2D.GetLength(1)];
    int k = 0;

    for (int i = 0; i < array2D.GetLength(0); ++i)
    {
        for (int j = 0; j < array2D.GetLength(1); ++j)
        {
            array1D[k++] = array2D[i, j];
        }

    }
    return array1D;
}

void Sort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}

void CountElements(int[] array)
{
    int count = 1;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == array[i + 1]) ++count;
        else
        {
            Console.WriteLine($"{array[i]} встречается {count} раз");
            count = 1;
        }
    }
    Console.WriteLine($"{array[array.Length - 1]} встречается {count} раз");
}

Console.Clear();
int[,] array2D = GetArray(4, 4, -4, 4);
PrintArray(array2D);
Console.WriteLine();
int[] array1D = Transform2Dto1D(array2D);
Sort(array1D);
CountElements(array1D);

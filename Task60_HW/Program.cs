// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[] GetShuffleArray(int[] array)
{
    Random rng = new Random();
    int l = array.Length;
    while (l > 1)
    {
        --l;
        int k = rng.Next(l + 1);
        int temp = array[k];
        array[k] = array[l];
        array[l] = temp;
    }
    return array;
}
int[] RandomUniqArray(int min, int max)
{
    int[] values = new int[max - min + 1];
    for (int i = min; i <= max; i++)
    {
        values[i - min] = i;
    }
    return GetShuffleArray(values);
}

int[,,] GetArray3D(int m, int n, int l, int minValue, int maxValue)
{
    int[] values = RandomUniqArray(minValue, maxValue);
    int[,,] array3D = new int[m, n, l];
    int count = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = values[count++];
            }
        }
    }

    return array3D;
}

void PrintArray3D(int[,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int l = 0; l < matrix3D.GetLength(2); l++)
            {
                Console.Write($"{matrix3D[i, j, l]} ({i} {j} {l}) \t ");
            }
        }
        Console.WriteLine();
    }
}


Console.Clear();


int[,,] mymatrix3D = GetArray3D(4, 4, 4, 1, 99);
PrintArray3D(mymatrix3D);


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


Console.Clear();


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}


int CountElements(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item >= 100 && item <= 999 && (item % 2 == 0))
        {

            count++;
        }
    }
    return count;
}

int[] array = GetArray(20, 100, 999);
Console.WriteLine(string.Join(",", array));
int end = CountElements(array);
Console.Write($"Количество четных элементов массива равно {end} ");
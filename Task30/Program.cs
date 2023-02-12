
// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
Console.Clear();

int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] Result = new int[size];

    for (int i = 0; i < size; i++)
    {
        Result[i] = new Random().Next(MinValue, MaxValue + 1);
    }
    return Result;
}
int[] MultArray(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 != 0) size++;
    int[] result = new int[size];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 != 0)
    result[size - 1] = array[array.Length / 2];
    return result;
}
int[] array1 = GetArray(4, -9, 9);
Console.WriteLine(string.Join(",", array1));
int[] array2 = MultArray(array1);
Console.WriteLine(string.Join(",", array2));


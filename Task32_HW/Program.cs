// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


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

int[] array = GetArray(5, -10, 10);
Console.WriteLine(String.Join(", ", array));

int Sum_Odd = 0;

for (int i = 0; i < array.Length; i++)
{
    // Console.WriteLine($"{i%2}");
    if ((i % 2) != 0)
    {
        Sum_Odd = Sum_Odd + array[i];
    }
}

Console.WriteLine($"Сумма нечетных элементов массива равна {Sum_Odd}");
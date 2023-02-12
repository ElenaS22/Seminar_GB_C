// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

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

int[] array = GetArray(10, -100, 100);
Console.WriteLine(String.Join(", ", array));

int max = int.MinValue;
int min = int.MaxValue;
int  Diffelement = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        // найден больший элемент
        max = array[i];
    }
    else if (array[i] < min)
     {
        // найден меньший  элемент
        min = array[i];
    }
    Diffelement = max - min;
}
Console.WriteLine($" max =  {max}");
Console.WriteLine($" min =  {min}");
Console.WriteLine($"Разница максимального и минимального элемента массива равна {Diffelement}");
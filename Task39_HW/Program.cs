// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

int ReadInfo(string message)
{
    Console.Write(message);
    string info = Console.ReadLine();
    int result = Convert.ToInt32(info);
    return result;
}
int[] NewArray(int length)
{
int[] array = new int[length];
for (int i = 0; i < array.Length; i++)
{
    array[i] = ReadInfo($"Введите  {i + 1} элемент");
}
return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"а [{i}] = {array[i]}");
}
}

int CountPositiveNumbers( int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
return count;
}

int length = ReadInfo($"Введите количество элементов >");
int[] array;
array = NewArray(length);
PrintArray(array);
Console.WriteLine($"Количество элементов больше 0 = {CountPositiveNumbers(array)} ");
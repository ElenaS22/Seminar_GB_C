// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

int[] getArray()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next();
    }
    return array;
}
void printArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
        Console.Write($"{inArray[i]} ");
}
int[] array = getArray();
printArray(array);
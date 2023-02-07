// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Clear();

int Multi(int number)
{
    int prod = 1;
    for (int i = 1; i <= number; i++)
    {
        prod *= i;
    }
    return prod;
}
Console.WriteLine("Введите число N ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Произведение чисел от 1 до {N} равно {Multi(N)}");
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

Console.Clear();

Console.Write("Введите число N: ");

int N = int.Parse(Console.ReadLine()!);

int a = 1;

while (a <= N)
{
    Console.Write($"{a * a} ");
    a++;
}
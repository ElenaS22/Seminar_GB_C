// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N");

int N = int.Parse(Console.ReadLine()!);
int K = 0;

while (K <= N)
{
Console.Write($"{K} ");
K = K+2;
}
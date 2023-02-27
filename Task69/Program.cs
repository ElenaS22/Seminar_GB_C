// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.

Console.Clear();

Console.Clear();

int Sqr (int A, int B)
{
    if (B == 0) return 1;
    return Sqr(A, B - 1) * A;
}
Console.Write($"Enter number 1: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write($"Enter number 2: ");
int B = int.Parse(Console.ReadLine()!);
Console.WriteLine(Sqr(A, B));
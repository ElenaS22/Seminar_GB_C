/// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();

int SumDig(int n)
{
    if (n == 0) return 0;
    return n % 10 + SumDig(n / 10);
}

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumDig(N));
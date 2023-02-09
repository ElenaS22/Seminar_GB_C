// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int Summa(int N)
{
    int S = 0;
    while (N > 0)
    {
        S = S + (N % 10);
        N = N / 10;
    }
    return S;
}
Console.WriteLine("Введите число N ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма цифр в числе {N} составляет {Summa(N)}");
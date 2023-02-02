// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Clear();

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);
int C = N % 7;
int B = N % 23;

if (C == 0 && B ==0)
{
Console.WriteLine("Кратно");
}
else
{
Console.WriteLine("Не кратно");
}
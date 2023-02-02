// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.WriteLine("Введите трехзначное число N");
int N = int.Parse(Console.ReadLine()!);
int B = N % 10;
int C = (N / 100) * 100;
int D = (N - C - B) / 10;

Console.WriteLine($"Вторая цифра числа {N} будет {D}");


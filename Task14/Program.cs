// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();

Console.Write("Введите четверть N ");
int N = int.Parse(Console.ReadLine()!);

if (N == 1)
{
    Console.Write("Координаты Х > 0, Y > 0");
}
else if (N == 2)
{
    Console.Write("Координаты Х < 0, Y > 0");
}
else if (N == 3)
{
    Console.Write("Координаты Х < 0, Y < 0");
}
else if (N == 4)
{
    Console.Write("Координаты Х > 0, Y < 0");
}
else
{
    Console.Write("Введите значение от 1 до 4");
}
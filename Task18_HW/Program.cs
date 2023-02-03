// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Введите x1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите z1: ");
int z1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите x0: ");
int x0 = int.Parse(Console.ReadLine()!);
Console.Write("Введите y0: ");
int y0 = int.Parse(Console.ReadLine()!);
Console.Write("Введите z0: ");
int z0 = int.Parse(Console.ReadLine()!);

int x2 = x1 - x0;
double sqr1 = Math.Pow(x2, 2);

int y2 = y1 - y0;
double sqr2 = Math.Pow(y2, 2);

int z2 = z1 - z0;
double sqr3 = Math.Pow(z2, 2);

double sqrt = sqr1 + sqr2 + sqr3;
double res = Math.Sqrt(sqrt);

Console.WriteLine($"{res:f2}");

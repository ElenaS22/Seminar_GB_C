// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


Console.Clear();

Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine()!);

while (N > 999)
{
   N = N / 10;
}
int count = 10;
int result = N % count;

if (N < 100)
{
    Console.WriteLine("В веденном числе отсутствует третья цифра");
}
else
{
    N = N % 10;
    Console.WriteLine($"В веденном числе третья цифра = {N}");
}
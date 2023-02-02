// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления/
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно

Console.Clear();

Console.WriteLine("Введите число A");

int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число B");

int B = int.Parse(Console.ReadLine()!);
int C = (A % B);

if  (C == 0)
{
Console.WriteLine("Кратно");
}
else
{
  Console.WriteLine($"Не кратно, остаток {C}");
}
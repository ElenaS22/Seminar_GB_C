﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Для проверки числа на чётность введите целое число ");

int number = int.Parse(Console.ReadLine()!);

if (number % 2 == 0)
{
    Console.Write("ДА, число является чётным");
}
else
{
    Console.Write("НЕТ, число не является чётным");
}
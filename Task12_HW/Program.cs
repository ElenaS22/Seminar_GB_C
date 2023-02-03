// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

Console.Write("Введите цифру для определения дня недели ");
int number = int.Parse(Console.ReadLine()!);


if (number < 1 || number > 7)
{
    Console.WriteLine("Требуется ввести число от 1 о 7");
}

else if (number == 6 || number == 7)
{
    Console.WriteLine("Да, выходной");
}

else
{
    Console.WriteLine("Нет, работаем");
}


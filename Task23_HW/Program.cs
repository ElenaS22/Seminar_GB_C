//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. Реализовать функцию возведения в степень самостоятельно!

Console.Clear();

// int Expo(int A, int B)
// {
//     int A1 = 1;
//     int i = 1;
//     while (i <= B && B != 0 && B != 1)
//     {
//         A1 = A * A1;
//         i++;
//     }
//     if (B == 1)
//     {
//         A1 = A;
//     }
//     return A1;
// }
// Console.WriteLine("Введите число A ");
// int A = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите число B ");
// int B = int.Parse(Console.ReadLine()!);

// Console.WriteLine($"Число {A} в степени {B} составит {Expo(A, B)}");

int Powe(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }
    return result;
}

Console.Write($"Введите A: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write($"Введите B: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine($"{a}^{b} = {Powe(a, b)}");
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int SummOfElements(int M, int N)
{
int summNM = 0;
 if (M == N) return summNM = M;
if (M <= N)
{
    summNM = M + SummOfElements(M+1, N);
    M++;
    return summNM;
   }
 return summNM;
}

Console.Clear();

Console.Write("Введите число M: ");
 int M = int.Parse(Console.ReadLine()!);
 Console.Write("Введите число N: ");
 int N = int.Parse(Console.ReadLine()!);
 Console.WriteLine(SummOfElements(M, N));


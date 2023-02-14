// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


/* Задача 68: Напишите программу вычисления функции Аккермана с помощью 
рекурсии. Даны два неотрицательных числа m и n. 
m = 2, n = 3 -> A(m,n) = 29 */

Console.Clear();
Console.Write("Для решения функции Аккермана введите первое число(M):");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Для решения функции Аккермана введите второе число(N):");
int n = Convert.ToInt32(Console.ReadLine());

int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AckermannFunction(m - 1, 1);
    else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

Console.WriteLine($"Результат вычисления функции Аккермана = '{AckermannFunction(m,n)}'");
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Clear();
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N, большее чем M: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 0 || m < 0) 
{Console.WriteLine("Перезапустите программу и введите положительные числа");}

if (m > n)
{Console.WriteLine("Перезапустите программу и введите числа согласно условий");}

int SumNaturalNumbersFromTo(int num1, int num2)
{
    if (num1 == num2) return num1;
    else return num1 + SumNaturalNumbersFromTo(num1+1, num2);
}

Console.WriteLine($"Сумма натуральных чисел '{m}' и '{n}' равна '{SumNaturalNumbersFromTo(m,n)}'");
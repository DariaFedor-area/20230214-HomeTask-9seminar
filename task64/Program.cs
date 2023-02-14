// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Clear();
Console.WriteLine("Введите значение N и мы выведем на экран все натуральные числа от N до 1");
int n = Convert.ToInt32(Console.ReadLine());

void ShowNaturalNumbers(int num)
{
    if (num < 1) //проверка введенного значения, если оно меньше мин.интервала
    {
        Console.Write("Значение меньше 1. Введите значение больше введенного");
        return;
    }
    if (num == 1) Console.Write(num);
    else
    {
        Console.Write($"{num} ");
        ShowNaturalNumbers(num-1);
    }
}

Console.WriteLine($"Натуральные числа от '{n}' до '1':");
ShowNaturalNumbers(n);
Console.WriteLine();
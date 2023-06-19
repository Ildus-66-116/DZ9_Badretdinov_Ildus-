﻿// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


string printNumbers(int a, int b)
{
    if (a == b)
        return $"{b}";
    return printNumbers(a, b + 1) + $", {b}";
}


Console.Clear();
Console.Write("Введите число: ");
int m = int.Parse(Console.ReadLine()!);
int n = 1;
Console.WriteLine(printNumbers(m, n));
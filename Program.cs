// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// string printNumbers(int a, int b)
// {
//     if (a == b)
//         return $"{b}";
//     return printNumbers(a, b + 1) + $", {b}";
// }


// Console.Clear();
// Console.Write("Введите число: ");
// int m = int.Parse(Console.ReadLine()!);
// int n = 1;
// Console.WriteLine(printNumbers(m, n));

// Задача 66: 
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int summaCifr(int a, int b)
// {
//     if (a >= b)
//         return a;
//     return summaCifr(a, b - 1) + b;
// }


// Console.Clear();
// Console.Write("Введите 1-ое число: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.Write("Введите 2-ое число: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine(summaCifr(m, n));

// Задача 68: 
// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


static int A(int n, int m)
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return A(n - 1, 1);
    if (n > 0 && m > 0) return A(n - 1, A(n, m - 1));
    return A(n,m);
}

Console.Clear();
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(A(n, m));
            


// Задайте значения M и N.
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

using System;
using static System.Console;

Clear();
Write("Введите N: ");
int n = int.Parse(ReadLine());
Write("Введите M: ");
int m = int.Parse(ReadLine());

if (n > m)
{
    WriteLine(PrintNumbers(m, n));
}
else if (n < m)
{
    WriteLine(PrintNumbers(n, m));
}
else if (n == m)
{
    WriteLine("Числа равны");
}

string PrintNumbers(int start, int end)
{
    if (start == end)
        return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}

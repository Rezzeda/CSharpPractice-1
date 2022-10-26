// Задайте значения M и N.
//Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N.

using System;
using static System.Console;

Clear();
Write("Введите N: ");
int n = int.Parse(ReadLine());
Write("Введите M: ");
int m = int.Parse(ReadLine());

if (n > m)
{
    WriteLine(SumNumbers(m, n));
}
else if (n < m)
{
    WriteLine(SumNumbers(n, m));
}
else if (n == m)
{
    WriteLine("Числа равны");
}

int SumNumbers(int start, int end)
{
    if (start == end)
    return end;
    return (start + SumNumbers(start+1, end));
}

// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

using System;
using static System.Console;

Clear();
Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());


WriteLine($"Значение функции Аккермана = {AkkermanFunc(m, n)}");

int AkkermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (n == 0)
    {
        return AkkermanFunc(m - 1, 1);
    }
    else
    {
        return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
    }
}

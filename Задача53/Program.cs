// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

using System;
using static System.Console;


Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
WriteLine();
SortGorizArray(array);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }

    }
    return result;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}

void SortGorizArray(int[,] inArray)
{
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        int i = inArray.GetLength(1);
        int temp = inArray[0, j];
        inArray[0, j] = inArray[i - 1, j];
        inArray[i - 1, j] = temp;
    }
    PrintArray(inArray);
}

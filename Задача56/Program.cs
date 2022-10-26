// Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

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

int[] sumRows = GetRowSum(array);
WriteLine($"Сумма по каждой строке = {String.Join("; ", sumRows)}");
WriteLine($"Минимальная сумма строки {MinElement(sumRows)}");

WriteLine($"В строке с индексом {GetRow(sumRows)}");


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

int[] GetRowSum(int[,] array)
{
    int[] result = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        result[i] = sum;
    }
    return result;
}

int MinElement(int[] array)
{
    int min = array[0];
    for (int j = 0; j < array.Length; j++)
    {
        if (min > array[j])
        {
            min = array[j];
        }
    }
    return min;
}

int GetRow(int[] array)
{
    int min = array[0];
    int k = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (min > array[j])
        {
            min = array[j];
            k = j;
        }
    }
    return k;
}
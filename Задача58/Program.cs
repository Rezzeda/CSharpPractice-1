// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
using System;
using static System.Console;

Clear();

Write("Введите количество строк массивов: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов массивов: ");
int columns = int.Parse(ReadLine());

int[,] array1 = GetArray(rows, columns, 0, 10);
PrintArray(array1);
WriteLine();
int[,] array2 = GetArray(rows, columns, 0, 10);
PrintArray(array2);
WriteLine();
int[,] array3 = multiplyArray(array1, array2);
PrintArray(array3);

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

int[,] multiplyArray(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array1.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(0); k++)
                result[i,j] += array1[i,k] * array2[k,j];
        }
    }
    return result;
}
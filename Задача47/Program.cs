// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
using System; // <- это чтоб не писать Console.
using static System.Console; // <- это чтоб не писать Console.

Clear();

Write("Введите количество строк массива: ");
int rows = int.Parse(ReadLine());

Write("Введите количество столбцов массива: ");
int columns = int.Parse(ReadLine());

double[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Random rand = new Random();
            int num = new Random().Next(minValue, maxValue);
            result[i, j] = Math.Round(num + rand.NextDouble(), 2);
        }
    }
    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}
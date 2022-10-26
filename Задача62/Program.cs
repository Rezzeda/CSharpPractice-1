// Напишите программу, которая заполнит спирально массив 4 на 4.
using System;
using static System.Console;

Clear();

int[,] array = GetArray(4, 4);
WriteLine();
PrintArray(ChangeArray(array));


int[,] GetArray(int m, int n)
{
    m = 4; n = 4;
    int[,] result = new int[m, n];
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= m * n)
    {
        result[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < result.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= result.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > result.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return result;
}

void PrintArray(string[,] inArray)
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

string[,] ChangeArray(int[,] inArray1)
{
    string[,] inArray2 = new string [inArray1.GetLength(0),inArray1.GetLength(1)];
    for (int i = 0; i < inArray1.GetLength(0); i++)
    {
        for (int j = 0; j < inArray1.GetLength(1); j++)
        {
            if (inArray1[i, j] < 10)
            {
                string k = "0" + inArray1[i, j].ToString();
                inArray2[i, j] =k;
            }
            else
            {
                string l = inArray1[i, j].ToString();
                inArray2[i, j] =l;
            }
        }
    }
    return inArray2;
}
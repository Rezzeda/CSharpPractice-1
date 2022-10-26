// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

int [] array = FillArray(6,100,999);

Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"Количество четных чисел = {EvenNumbers(array)}]");

int [] FillArray (int size, int minValue, int maxValue)
{
    int [] arr = new int [size];
    for (int i=0; i<size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
    return arr;
}

int EvenNumbers (int [] array)
{
   int count = 0;
    foreach (var item in array)
    {
        if (item%2==0) count++;
    }
    return count;
}


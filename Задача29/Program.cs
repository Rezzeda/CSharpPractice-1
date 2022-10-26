// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();

int[] array = FillArray(8);
Console.WriteLine($"[{String.Join(",", array)}]");


int[] FillArray (int size)
{
    int [] arr = new int [size];
    for (int i=0; i<size; i++)
    {
        arr[i] = new Random().Next(100);
    }
    return arr;
}
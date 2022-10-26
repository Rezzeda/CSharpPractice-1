// напишите программу, которая выводит массив из 8 элементов, заполненный 0 и 1 в случайном порядке
Console.Clear();

int[] array = FillArray(8);
Console.WriteLine($"[{String.Join(",", array)}]");


int[] FillArray (int size)
{
    int [] arr = new int [size];
    for (int i=0; i<size; i++)
    {
        arr[i] = new Random().Next(2);
    }
    return arr;
}
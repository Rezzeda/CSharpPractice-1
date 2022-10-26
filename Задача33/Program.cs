// Задайте массив. Напишите программу, которая опрелеляет, присутствует ли заданное число в массиве.
Console.Clear();

int [] array = FillArray(12,1,8);
Console.WriteLine($"[{String.Join(",", array)}]");

int n=6;
if (FindElement(n,array))
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}

int [] FillArray (int size, int minValue, int maxValue)
{
    int [] arr = new int [size];
    for (int i=0; i<size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
    return arr;
}

bool FindElement (int n, int[] array)
{
    int j=0;
    foreach (var item in array )
    {
        if(array[j] == n) return true;
    }
    return false;
}
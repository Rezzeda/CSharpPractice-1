// Напишите программу замена элементов массива, положительные эдементы заменить на соответствующие отрицательные и наоборот.
Console.Clear();

int [] array = FillArray(10,-10,10);

Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"[{String.Join(",", OppositeArray(array))}]");

int [] FillArray (int size, int minValue, int maxValue)
{
    int [] arr = new int [size];
    for (int i=0; i<size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
    return arr;
}

int [] OppositeArray (int [] array1)
{
    for (int j = 0; j<array1.Length; j++)
    {
        array1[j]*=-1;
    }
    return array1;
}


// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

double [] array = FillArray(5,-1,10);

double result = Math.Round(MaxElement(array) - MinElement(array),2);
Console.WriteLine($"[{String.Join("  ", array)}]");

Console.WriteLine($"Разница между максимальным элементом {MaxElement(array)} и минимальным {MinElement(array)} равна {result}");

//Сделала эту ф-ю с помощью интернета:

double [] FillArray (int size, int minValue, int maxValue)
{
    double [] arr = new double [size];
    Random rand = new Random();
    for (int i=0; i<size; i++)
    {
        int n = new Random().Next(minValue, maxValue);
        arr[i] = Math.Round(n + rand.NextDouble(),2);
    }
    return arr;
}

double MaxElement (double [] array)
{
    double max = array[0];
    for (int j=0; j<array.Length;j++)
    {
        if (max < array[j])
        {
            max = array[j];
        }
    }
    return max;
}

double MinElement (double [] array)
{
    double min = array[0];
    for (int j=0; j<array.Length;j++)
    {
        if (min > array[j])
        {
            min = array[j];
        }
    }
    return min;
}


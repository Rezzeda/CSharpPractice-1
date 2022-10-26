// **Задача 35:** Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Console.Clear();

int [] array = FillArray(123,1,123);

Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"Количество элементов массива в промежутке [10,99] = {CountElements(array,10,99)}");

int [] FillArray (int size, int minValue, int maxValue)
{
    int [] arr = new int [size];
    for (int i=0; i<size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
    return arr;
}

int CountElements (int [] array, int leftRange, int rightRange)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item >= leftRange && item <= rightRange) count++;
    }
    return count;
}

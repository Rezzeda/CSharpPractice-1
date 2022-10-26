// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

int [] array = FillArray(5,1,10);

Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {SumElements(array)}");

int [] FillArray (int size, int minValue, int maxValue)
{
    int [] arr = new int [size];
    for (int i=0; i<size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
    return arr;
}

int SumElements (int [] array)
{
    int sum = 0;
    for (int i=1; i< array.Length; i+=2)
    {
        sum = sum + array[i];
    }
    return sum;
}
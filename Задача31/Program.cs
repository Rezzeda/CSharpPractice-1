// Задайте массив из 12 элементов заполненный случайными числами из промежутка [-9; 9].
// найдите сумму отрицательных и положительных элементов массива
Console.Clear();

double [] array = FillArray(12);
Console.WriteLine($"[{String.Join(",", array)}]");


double [] FillArray (int size)
{
    double [] arr = new double [size];
    for (int i=0; i<size; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
    return arr;
}

double GetSumPos (double [] arr)
{
    double sum1 = 0;
    for(int j = 0; j < arr.Length; j++)
    {
        if(arr[j]>0)
        {
            sum1 = sum1 + arr[j];
        }
    }
    return sum1;
}

double GetSumNeg (double [] arr)
{
    double sum2 = 0;
    for(int k = 0; k < arr.Length; k++)
    {
        if(arr[k]<0)
        {
            sum2 = sum2 + arr[k];
        }
    }
    return sum2;
}

Console.WriteLine($"Сумма положительных элементов = {GetSumPos(array)}");
Console.WriteLine($"Сумма отрицательных элементов = {GetSumNeg(array)}");
// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
Console.Clear();

int [] array = FillArray(6,1,5);

Console.WriteLine($"[{String.Join(",", array)}]");
Console.WriteLine($"[{String.Join(",", MultiplyElements(array))}]");

int [] FillArray (int size, int minValue, int maxValue)
{
    int [] arr = new int [size];
    for (int i=0; i<size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
    return arr;
}

int [] MultiplyElements (int [] array)
{
    int size1 = (array.Length + 1)/ 2;
    int [] mul = new int [size1];
    for(int j = 0; j<array.Length/2; j++)
    {
        mul[j]= array[j] * array[array.Length-1 - j];
    }
    return mul;
}
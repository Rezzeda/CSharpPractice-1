// Напишите программу, которая перевернет одномерный массив
//(последний элемент будет на первом месте, а первый на последнем)

Console.Clear();

int [] array = FillArray(5,1,10);
Console.WriteLine($"[{String.Join(" ", array)}]");

int [] reverseArray = reverseArray2(array);
Console.WriteLine($"[{String.Join(" ", reverseArray)}]");

reverseArray1(array);
Console.WriteLine($"[{String.Join(" ", array)}]");

int [] FillArray (int size, int minValue, int maxValue)
{
    int [] arr = new int [size];
    for (int i=0; i<size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue+1);
    }
    return arr;
}

void reverseArray1(int[] inArray)
{
    for(int i=0; i < inArray.Length /2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length -i - 1];
        inArray[inArray.Length - i -1] = k;
    }
}

int [] reverseArray2(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for(int i=0; i<inArray.Length; i++)
    {
        result[i] = inArray[inArray.Length -1 -i];
    }
    return result;
}